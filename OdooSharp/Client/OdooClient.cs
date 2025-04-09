using OdooSharp.Configuration;
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
    public class OdooClient
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

        //public async Task<List<T>> SearchReadAsync<T>(object[] domain = null, string[] fields = null)
        //{
        //    var model = _getModelName<T>();
        //    if (domain == null)
        //    {
        //        domain = _getDomain<T>();
        //    }

        //    var payload = new
        //    {
        //        jsonrpc = "2.0",
        //        method = "call",
        //        @params = new
        //        {
        //            service = "object",
        //            method = "execute_kw",
        //            args = new object[]
        //            {
        //                _options.Database,
        //                _session!.Uid,
        //                _options.Password,
        //                model,
        //                "search_read",
        //                new object[] { domain },
        //                new
        //                {
        //                    fields,
        //                    limit = 100
        //                }
        //            }
        //        },
        //        id = 1
        //    };

        //    var response = await _httpClient.PostAsync(
        //        $"{_options.Url}/jsonrpc",
        //        new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

        //    var json = await response.Content.ReadAsStringAsync();
        //    var doc = JsonDocument.Parse(json);
        //    var root = doc.RootElement.GetProperty("result");

        //    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //    return JsonSerializer.Deserialize<List<T>>(root.GetRawText(), options) ?? new List<T>();
        //}

        public async Task<JsonRpcResponse<List<T>>> SearchReadAsync<T>(object[] domain = null, string[] fields = null, int limit = 100, int offset = 0, string order = null)
        {
            var model = _getModelName<T>();
            if (domain == null)
            {
                domain = _getDomain<T>();
            }

            var args = new Dictionary<string, object>
            {
                ["fields"] = fields,
                ["limit"] = limit,
                ["offset"] = offset
            };

            if (!string.IsNullOrWhiteSpace(order))
            {
                args["order"] = order;
            }

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
                        args
                    }
                },
                id = 1
            };

            var response = await _httpClient.PostAsync(
                $"{_options.Url}/jsonrpc",
                new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

            return await _deserializeHttpReponseAsync<JsonRpcResponse<List<T>>>(response);
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

        public async Task<JsonRpcResponse<T>> GetByIdAsync<T>(int id, string[] fields = null)
        {
            var model = _getModelName<T>();

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
                        "read",
                        new object[] { new[] { id } },
                        new { fields = fields }
                    }
                },
                id = 1
            };

            var response = await _httpClient.PostAsync(
                $"{_options.Url}/jsonrpc",
                new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

            var listResponse = await _deserializeHttpReponseAsync<JsonRpcResponse<List<T>>>(response);
            return listResponse.FirstOrDefault();

            //var json = await response.Content.ReadAsStringAsync();
            //var doc = JsonDocument.Parse(json);
            //var result = doc.RootElement.GetProperty("result");

            //if (result.GetArrayLength() == 0)
            //    return default;

            //var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            //return JsonSerializer.Deserialize<T>(result[0].GetRawText(), options);
        }

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

        public async Task<JsonRpcResponse<int>> CreateAsync<T>(string model, T data)
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
                        "create",
                        new object[] { data }
                    }
                },
                id = 1
            };

            var response = await _httpClient.PostAsync(
                $"{_options.Url}/jsonrpc",
                new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"));

            return await _deserializeHttpReponseAsync<JsonRpcResponse<int>>(response);
            //var json = await response.Content.ReadAsStringAsync();
            //var doc = JsonDocument.Parse(json);
            //return doc.RootElement.GetProperty("result").GetInt32();
        }

        public async Task<JsonRpcResponse<bool>> WriteAsync<T>(string model, int id, T values)
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
                        "write",
                        new object[] { new[] { id }, values }
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
    }
}
