using OdooSharp.Configuration;
using OdooSharp.Extensions;
using OdooSharp.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OdooSharp.Client
{
    public class OdooClient : IOdooClient
    {
        private readonly HttpClientHandler _httpClientHandler;
        private readonly HttpClient _httpClient;
        private readonly OdooClientOptions _options;
        private OdooSession _session;

        public OdooClient(OdooClientOptions options)
        {
            _httpClientHandler = new HttpClientHandler
            {
                CookieContainer = new CookieContainer(),
                UseCookies = true
            };
            _httpClient = new HttpClient(_httpClientHandler);
            _options = options;
        }

        public async Task<bool> AuthenticateAsync()
        {
            var payload = new
            {
                jsonrpc = "2.0",
                method = "call",
                @params = new
                {
                    db = _options.Database,
                    login = _options.Username,
                    password = _options.Password
                },
                id = 1
            };

            var response = await _httpClient.PostAsync(
                $"{_options.Url}/web/session/authenticate",
                new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);
            if (doc.RootElement.TryGetProperty("result", out var result))
            {
                _session = new OdooSession
                {
                    Uid = result.GetProperty("uid").GetInt32(),
                };
                return true;
            }
            return false;
        }

        public async Task<List<OdooModel>> GetModelsAsync() => await SearchReadAllPagedAsync<OdooModel>(new object[0], new string[] { "model", "name" });

        public async Task<OdooFieldsResponse> GetModelFieldsTypedAsync(string model)
        {
            var payload = new
            {
                jsonrpc = "2.0",
                method = "call",
                @params = new
                {
                    service = "object",
                    method = "execute_kw",
                    args = new object[]
                    {
                        _options.Database,
                        _session!.Uid,
                        _options.Password,
                        model,
                        "fields_get",
                        new object[] { },
                        new { }
                    }
                },
                id = 2
            };

            var response = await _httpClient.PostAsync(
                $"{_options.Url}/jsonrpc",
                new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<OdooFieldsResponse>(json, options) ?? new OdooFieldsResponse();
        }

        public async Task<JsonRpcResponse<OdooFieldsResponse>> GetModelFieldTypedAsync(string model, string fieldName) => await _postAsync<OdooFieldsResponse>(model, OdooMethod.fields_get, new object[] { fieldName });
        public async Task<OdooFieldsResponse> GetModelFieldTypedAsyncOld(string model, string fieldName)
        {
            var payload = new
            {
                jsonrpc = "2.0",
                method = "call",
                @params = new
                {
                    service = "object",
                    method = "execute_kw",
                    args = new object[]
                    {
                        _options.Database,
                        _session!.Uid,
                        _options.Password,
                        model,
                        "fields_get",
                        new object[] { fieldName },
                        new { }
                    }
                },
                id = 2
            };

            var response = await _httpClient.PostAsync(
                $"{_options.Url}/jsonrpc",
                new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<OdooFieldsResponse>(json, options) ?? new OdooFieldsResponse();
        }

        public async Task<JsonRpcResponse<int>> SearchReadCountAsync<T>(/*Expression<Func<T, bool>> predicate = null*/)
        {
            //var domain = predicate != null ? (object[])new OdooExpressionParser().Parse(predicate.Body) : _getDomain<T>();
            var domain = _getDomain<T>();

            return await _postAsync<T, int>(OdooMethod.search_count, new object[] { domain });

        }

        public async Task<JsonRpcResponse<List<T>>> SearchReadAsync<T>(object[] domain = null, string[] fields = null, int limit = 100, int offset = 0, string order = null)
        {
            var model = _getModelName<T>();
            domain ??= _getDomain<T>();

            var kwargs = new Dictionary<string, object>
            {
                ["fields"] = fields ?? Array.Empty<string>(),
                ["limit"] = limit,
                ["offset"] = offset
            };

            if (!string.IsNullOrWhiteSpace(order))
            {
                kwargs["order"] = order;
            }

            return await _postAsync<T, List<T>>(OdooMethod.search_read, new object[] { domain }, kwargs);
        }

        private async Task<T> _deserializeHttpReponseAsync<T>(HttpResponseMessage responseMessage)
        {
            var json = await responseMessage.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            try
            {
                return JsonSerializer.Deserialize<T>(json, options);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine($"Provided json: {json}");
                Console.WriteLine();
            }
            return default;
        }

        public async Task<JsonRpcResponse<T>> ReadById<T>(int id) => await _postAsync<T, T>(OdooMethod.read, new object[] { new[] { id } });

        public async Task<List<T>> SearchReadAllPagedAsync<T>(object[] domain = null, string[] fields = null, int pageSize = 100)
        {
            var model = _getModelName<T>();
            if (domain == null)
            {
                domain = _getDomain<T>();
            }

            var results = new List<T>();
            int offset = 0;
            while (true)
            {
                var payload = new
                {
                    jsonrpc = "2.0",
                    method = "call",
                    @params = new
                    {
                        service = "object",
                        method = "execute_kw",
                        args = new object[]
                        {
                            _options.Database,
                            _session!.Uid,
                            _options.Password,
                            model,
                            "search_read",
                            new object[] { domain },
                            new
                            {
                                fields = fields,
                                limit = pageSize,
                                offset = offset
                            }
                        }
                    },
                    id = 1
                };

                var response = await _httpClient.PostAsync(
                    $"{_options.Url}/jsonrpc",
                    new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

                var json = await response.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(json);
                var page = JsonSerializer.Deserialize<List<T>>(doc.RootElement.GetProperty("result").GetRawText());

                if (page == null || page.Count == 0) break;
                results.AddRange(page);
                offset += pageSize;
            }
            return results;
        }

        public async Task<JsonRpcResponse<int>> CreateAsync<T>(T data) => await _postAsync<T, int>(OdooMethod.create, new object[] { data });

        public async Task<JsonRpcResponse<bool>> WriteAsync<T>(T values)
        {
            var type = typeof(T);
            var idProp = type.GetProperty("Id");
            if (idProp == null)
            {
                throw new InvalidOperationException($"Model {type.Name} is missing 'Id' property.");
            }

            var id = idProp.GetValue(values);
            if (id == null || (int)id == 0)
            {
                throw new InvalidOperationException($"Model {type.Name} has invalid 'Id' value.");
            }

            return await _postAsync<T, bool>(OdooMethod.write, new object[] { new[] { id }, values });
        }

        public async Task<JsonRpcResponse<bool>> DeleteAsync<T>(int id) => await _postAsync<T, bool>(OdooMethod.unlink, new object[] { id });

        public async Task<JsonRpcResponse<bool>> DeleteAsync(string model, int id)
        {
            var payload = new
            {
                jsonrpc = "2.0",
                method = "call",
                @params = new
                {
                    service = "object",
                    method = "execute_kw",
                    args = new object[]
                    {
                        _options.Database,
                        _session!.Uid,
                        _options.Password,
                        model,
                        "unlink",
                        new object[] { new[] { id } }
                    }
                },
                id = 1
            };

            var response = await _httpClient.PostAsync(
                $"{_options.Url}/jsonrpc",
                new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

            return await _deserializeHttpReponseAsync<JsonRpcResponse<bool>>(response);
            //var json = await response.Content.ReadAsStringAsync();
            //var doc = JsonDocument.Parse(json);
            //return doc.RootElement.GetProperty("result").GetBoolean();
        }

        #region Helper

        private async Task<JsonRpcResponse<Tout>> _postAsync<T, Tout>(OdooMethod method, object[] methodArgs, Dictionary<string, object> kwargs = null)
        {
            var payload = _request<T>(method, methodArgs, kwargs);
            var response = await _postAsync(payload);
            return await _deserializeHttpReponseAsync<JsonRpcResponse<Tout>>(response);
        }

        private async Task<JsonRpcResponse<Tout>> _postAsync<Tout>(string model, OdooMethod method, object[] methodArgs, Dictionary<string, object> kwargs = null)
        {
            var payload = _request(model, method, methodArgs, kwargs);
            var response = await _postAsync(payload);
            return await _deserializeHttpReponseAsync<JsonRpcResponse<Tout>>(response);
        }

        private async Task<HttpResponseMessage> _postAsync<T>(T payload)
            where T : OdooRpcRequest
            => await _httpClient.PostAsync($"{_options.Url}/jsonrpc", new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

        private OdooRpcRequest<OdooRpcParams> _request<T>(OdooMethod method, object[] methodArgs, Dictionary<string, object> kwargs = null)
        {
            var model = _getModelName<T>();
            return _request(model, method, methodArgs, kwargs);
        }
        private OdooRpcRequest<OdooRpcParams> _request(string model, OdooMethod method, object[] methodArgs, Dictionary<string, object> kwargs = null) => _request("object", "execute_kw", _args(model, method, methodArgs, kwargs));
        private OdooRpcRequest<OdooRpcParams> _request(string service, string method, OdooExecuteKwArgs args) => new OdooRpcRequest<OdooRpcParams>()
        {
            Params = new OdooRpcParams()
            {
                Service = service,
                Method = method,
                Args = OdooArgsBuilder.FromExecuteKw(args)
            }
        };

        private OdooExecuteKwArgs _args(string model, OdooMethod method, object[] methodArgs, Dictionary<string, object> kwargs) => new OdooExecuteKwArgs()
        {
            Db = _options.Database,
            UserId = _session!.Uid,
            Password = _options.Password,
            Model = model,
            Method = method.ToString(),
            MethodArgs = methodArgs,
            Kwargs = kwargs
        };

        private string _getModelName<T>()
        {
            var attr = typeof(T).GetCustomAttribute<OdooModelAttribute>();
            if (attr == null)
            {
                throw new InvalidOperationException("OdooModelAttribute missing for type " + typeof(T).Name);
            }

            if (string.IsNullOrWhiteSpace(attr.ModelName))
            {
                throw new ArgumentException("OdooModelAttribute model name is invalid");
            }

            return attr.ModelName;
        }

        private object[] _getDomain<T>()
        {
            var attr = typeof(T).GetCustomAttribute<OdooModelAttribute>();
            if (attr == null)
            {
                throw new InvalidOperationException("OdooModelAttribute missing for type " + typeof(T).Name);
            }

            object[] domain = new object[0];

            if (!string.IsNullOrEmpty(attr.DomainJson))
            {
                domain = JsonSerializer.Deserialize<object[]>(attr.DomainJson) ?? throw new Exception("Unable to deserialize Domain-JSON.");
            }

            return domain;
        }

        #endregion
    }
}
