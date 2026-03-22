using OdooSharp.Configuration;
using OdooSharp.Exceptions;
using OdooSharp.Extensions;
using OdooSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace OdooSharp.Client
{
    public class OdooClient : IOdooClient, IDisposable
    {
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        private readonly HttpClientHandler _httpClientHandler;
        private readonly HttpClient _httpClient;
        private readonly OdooClientOptions _options;
        private OdooSession _session;
        private bool _disposed;
        public bool Authenticated => _session != null;

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

        [Obsolete("Use AuthenticateAsync(CancellationToken) overload.")]
        public async Task<bool> AuthenticateAsync()
        {
            return await AuthenticateAsync(CancellationToken.None);
        }

        public async Task<bool> AuthenticateAsync(CancellationToken ct)
        {
            var uid = await AuthenticateUserLightAsync(_options.Username, _options.Password, ct);
            if (uid.HasValue)
            {
                _session = new OdooSession
                {
                    Uid = uid.Value
                };
                return true;
            }
            return false;
        }

        [Obsolete("Use AuthenticateUserAsync(string, string, CancellationToken) overload.")]
        public async Task<OdooAuthEnvelope> AuthenticateUserAsync(string username, string password)
        {
            return await AuthenticateUserAsync(username, password, CancellationToken.None);
        }

        public async Task<OdooAuthEnvelope> AuthenticateUserAsync(string username, string password, CancellationToken ct)
        {
            var payload = new
            {
                jsonrpc = "2.0",
                method = "call",
                @params = new
                {
                    db = _options.Database,
                    login = username,
                    password = password
                },
                id = 1
            };

            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_options.Url}/web/session/authenticate", content, ct);

            return await _deserializeHttpReponseAsync<OdooAuthEnvelope>(response);
        }

        [Obsolete("Use AuthenticateUserLightAsync(string, string, CancellationToken) overload.")]
        public async Task<int?> AuthenticateUserLightAsync(string username, string password)
        {
            return await AuthenticateUserLightAsync(username, password, CancellationToken.None);
        }

        public async Task<int?> AuthenticateUserLightAsync(string username, string password, CancellationToken ct)
        {
            var payload = new
            {
                jsonrpc = "2.0",
                method = "call",
                @params = new
                {
                    service = "common",
                    method = "authenticate",
                    args = new object[]
                    {
                        _options.Database,
                        username,
                        password,
                        new { }
                    }
                },
                id = 1
            };

            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_options.Url}/jsonrpc", content, ct);
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new OdooHttpException(response.StatusCode, json);
            }

            using var doc = JsonDocument.Parse(json);

            if (doc.RootElement.TryGetProperty("result", out var resultElement))
            {
                if (resultElement.ValueKind == JsonValueKind.Number)
                {
                    var uid = resultElement.GetInt32();
                    if (uid == 0)
                    {
                        return null;
                    }
                    return uid;
                }
            }

            if (doc.RootElement.TryGetProperty("error", out var errorElement))
            {
                throw new Exception(errorElement.GetRawText());
            }

            return null;
        }

        public async Task<List<OdooModel>> GetModelsAsync() => await SearchReadAllPagedAsync<OdooModel>(new object[0], new string[] { "model", "name" });

        public async Task<OdooFieldsResponse> GetModelFieldsTypedAsync(string model)
        {
            if (!Authenticated)
            {
                throw new NotAuthenticatedException();
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
                        "fields_get",
                        new object[] { },
                        new { }
                    }
                },
                id = 2
            };

            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_options.Url}/jsonrpc", content);

            return await _deserializeHttpReponseAsync<OdooFieldsResponse>(response) ?? new OdooFieldsResponse();
        }

        public async Task<JsonRpcResponse<OdooFieldsResponse>> GetModelFieldTypedAsync(string model, string fieldName) => await _postAsync<OdooFieldsResponse>(model, OdooMethod.fields_get, new object[] { fieldName });

        [Obsolete("Use SearchReadCountAsync<T>(object[], CancellationToken) overload.")]
        public async Task<JsonRpcResponse<int>> SearchReadCountAsync<T>()
        {
            return await SearchReadCountAsync<T>(null, CancellationToken.None);
        }

        public async Task<JsonRpcResponse<int>> SearchReadCountAsync<T>(object[] domain, CancellationToken ct = default)
        {
            domain ??= _getDomain<T>();
            return await _postAsync<T, int>(OdooMethod.search_count, new object[] { domain });
        }

        [Obsolete("Use SearchReadAsync<T> overload with CancellationToken.")]
        public async Task<JsonRpcResponse<List<T>>> SearchReadAsync<T>(object[] domain = null, string[] fields = null, int limit = 100, int offset = 0, string order = null)
        {
            return await SearchReadAsync<T>(domain, fields, limit, offset, order, CancellationToken.None);
        }

        public async Task<JsonRpcResponse<List<T>>> SearchReadAsync<T>(object[] domain, string[] fields, int limit, int offset, string order, CancellationToken ct)
        {
            domain ??= _getDomain<T>();

            var kwargs = new Dictionary<string, object>
            {
                ["limit"] = limit,
                ["offset"] = offset
            };

            if (fields != null && fields.Length > 0)
            {
                kwargs["fields"] = fields;
            }

            if (!string.IsNullOrWhiteSpace(order))
            {
                kwargs["order"] = order;
            }

            return await _postAsync<T, List<T>>(OdooMethod.search_read, new object[] { domain }, kwargs);
        }

        private async Task<T> _deserializeHttpReponseAsync<T>(HttpResponseMessage responseMessage)
        {
            var json = await responseMessage.Content.ReadAsStringAsync();

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new OdooHttpException(responseMessage.StatusCode, json);
            }

            try
            {
                return JsonSerializer.Deserialize<T>(json, _jsonOptions);
            }
            catch (Exception ex)
            {
                throw new OdooDeserializationException(json, ex);
            }
        }

        [Obsolete("Use ReadById<T>(int, CancellationToken) overload.")]
        public async Task<JsonRpcResponse<T>> ReadById<T>(int id) => await ReadById<T>(id, CancellationToken.None);

        public async Task<JsonRpcResponse<T>> ReadById<T>(int id, CancellationToken ct) => (await _postAsync<T, T[]>(OdooMethod.read, new object[] { new[] { id } })).First<T>();

        public async Task<List<T>> SearchReadAllPagedAsync<T>(object[] domain = null, string[] fields = null, int pageSize = 100)
        {
            return await SearchReadAllPagedAsync<T>(domain, fields, pageSize, null, CancellationToken.None);
        }

        public async Task<List<T>> SearchReadAllPagedAsync<T>(object[] domain, string[] fields, int pageSize, string order, CancellationToken ct = default)
        {
            var results = new List<T>();
            int offset = 0;
            while (true)
            {
                ct.ThrowIfCancellationRequested();
                var response = await SearchReadAsync<T>(domain, fields, pageSize, offset, order, ct);
                var page = response.Result;

                if (page == null || page.Count == 0) break;
                results.AddRange(page);
                if (page.Count < pageSize) break;
                offset += pageSize;
            }
            return results;
        }

        [Obsolete("Use CreateAsync<T>(T, CancellationToken) overload.")]
        public async Task<JsonRpcResponse<int>> CreateAsync<T>(T data) => await CreateAsync<T>(data, CancellationToken.None);

        public async Task<JsonRpcResponse<int>> CreateAsync<T>(T data, CancellationToken ct)
        {
            var fields = _serializeWritableFields(data);
            return await _postAsync<T, int>(OdooMethod.create, new object[] { fields });
        }

        [Obsolete("Use WriteAsync<T>(T, CancellationToken) overload.")]
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

        [Obsolete("Use WriteChangedAsync<T>(T, CancellationToken) overload.")]
        public async Task<JsonRpcResponse<bool>> WriteChangedAsync<T>(T modified)
        {
            var type = typeof(T);
            var idProp = type.GetProperty("Id");
            if (idProp == null)
            {
                throw new InvalidOperationException($"Model {type.Name} is missing 'Id' property.");
            }

            var id = (int)idProp.GetValue(modified);
            var readResult = await ReadById<T>(id);
            if (readResult.Error != null)
            {
                return new JsonRpcResponse<bool>()
                {
                    Error = readResult.Error,
                    Result = false,
                    JsonRpc = readResult.JsonRpc
                };
            }

            var original = readResult.Result;
            return await WriteChangedAsync(original, modified);
        }

        [Obsolete("Use WriteChangedAsync<T>(T, T, CancellationToken) overload.")]
        public async Task<JsonRpcResponse<bool>> WriteChangedAsync<T>(T original, T modified)
        {
            return await WriteChangedAsync<T>(original, modified, CancellationToken.None);
        }

        public async Task<JsonRpcResponse<bool>> WriteChangedAsync<T>(T original, T modified, CancellationToken ct)
        {
            var type = typeof(T);
            var idProp = type.GetProperty("Id");
            if (idProp == null)
            {
                throw new InvalidOperationException($"Model {type.Name} is missing 'Id' property.");
            }

            var id = idProp.GetValue(modified);
            if (id == null || (int)id == 0)
            {
                throw new InvalidOperationException($"Model {type.Name} has invalid 'Id' value.");
            }

            var changedFields = GetChangedFields(original, modified);
            if (changedFields.Count == 0)
            {
                return new JsonRpcResponse<bool> { Result = true };
            }

            var methodArgs = new object[] { new[] { id }, changedFields };
            return await _postAsync<T, bool>(OdooMethod.write, methodArgs);
        }

        [Obsolete("Use DeleteAsync<T>(int, CancellationToken) overload.")]
        public async Task<JsonRpcResponse<bool>> DeleteAsync<T>(int id) => await DeleteAsync<T>(id, CancellationToken.None);

        public async Task<JsonRpcResponse<bool>> DeleteAsync<T>(int id, CancellationToken ct) => await _postAsync<T, bool>(OdooMethod.unlink, new object[] { new[] { id } });

        public async Task<JsonRpcResponse<bool>> DeleteAsync(string model, int id)
        {
            if (!Authenticated)
            {
                throw new NotAuthenticatedException();
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
                        "unlink",
                        new object[] { new[] { id } }
                    }
                },
                id = 1
            };

            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_options.Url}/jsonrpc", content);

            return await _deserializeHttpReponseAsync<JsonRpcResponse<bool>>(response);
        }

        #region Helper

        private Dictionary<string, object> _serializeWritableFields<T>(T data)
        {
            var result = new Dictionary<string, object>();
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                if (!prop.CanRead || prop.Name == "Id")
                    continue;

                var odooFieldAttr = prop.GetCustomAttribute<OdooFieldAttribute>();
                if (odooFieldAttr == null)
                    continue;

                if (odooFieldAttr.FieldName == "id" || odooFieldAttr.IsReadonly)
                    continue;

                var value = prop.GetValue(data);
                if (value == null)
                    continue;

                result[odooFieldAttr.FieldName] = value;
            }

            return result;
        }

        [Obsolete("Will be moved to a utility class in a future version.")]
        public Dictionary<string, object> GetChangedFields<T>(T original, T modified)
        {
            var changed = new Dictionary<string, object>();
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                if (!prop.CanRead || !prop.CanWrite || prop.Name == "Id")
                {
                    continue;
                }

                var odooFieldAttr = prop.GetCustomAttribute<OdooFieldAttribute>();
                if (odooFieldAttr == null)
                {
                    continue;
                }

                var fieldName = odooFieldAttr.FieldName;
                if (fieldName == "id")
                {
                    continue;
                }

                if (odooFieldAttr.IsReadonly)
                {
                    continue;
                }

                var originalValue = prop.GetValue(original);
                object modifiedValue = prop.GetValue(modified);

                if (!Equals(originalValue, modifiedValue))
                {
                    var converterTypeAttribute = prop.GetCustomAttribute<JsonConverterAttribute>();
                    if (converterTypeAttribute != null)
                    {
                        var converter = Activator.CreateInstance(converterTypeAttribute.ConverterType) as JsonConverter;
                        if (converter != null)
                        {
                            using var stream = new MemoryStream();
                            using var writer = new Utf8JsonWriter(stream);

                            var method = converterTypeAttribute.ConverterType.GetMethod("Write");
                            if (method == null)
                                throw new InvalidOperationException($"No Write method found in {converterTypeAttribute.ConverterType.Name}");

                            // Some converters are generic (JsonConverter<T>), so we need the generic type
                            var options = new JsonSerializerOptions();
                            method.Invoke(converter, new object[] { writer, modifiedValue, options });

                            writer.Flush();

                            // Parse the converter's JSON output back into the correct .NET type
                            // so that numbers stay as numbers, not strings.
                            var jsonBytes = stream.ToArray();
                            using var doc = JsonDocument.Parse(jsonBytes);
                            var element = doc.RootElement;

                            modifiedValue = element.ValueKind switch
                            {
                                JsonValueKind.Number => element.TryGetInt64(out var l) ? (object)l : element.GetDouble(),
                                JsonValueKind.True => true,
                                JsonValueKind.False => false,
                                JsonValueKind.Null => null,
                                JsonValueKind.String => prop.PropertyType == typeof(byte[])
                                    ? (object)Convert.FromBase64String(element.GetString())
                                    : element.GetString(),
                                _ => element.GetRawText(),
                            };
                        }
                    }

                    changed[fieldName] = modifiedValue;
                }
            }

            return changed;
        }

        private async Task<JsonRpcResponse<Tout>> _postAsync<T, Tout>(OdooMethod method, object[] methodArgs, Dictionary<string, object> kwargs = null)
        {
            if (!Authenticated)
            {
                throw new NotAuthenticatedException();
            }

            var payload = _request<T>(method, methodArgs, kwargs);
            var response = await _postAsync(payload);
            return await _deserializeHttpReponseAsync<JsonRpcResponse<Tout>>(response);
        }

        private async Task<JsonRpcResponse<Tout>> _postAsync<Tout>(string model, OdooMethod method, object[] methodArgs, Dictionary<string, object> kwargs = null)
        {
            if (!Authenticated)
            {
                throw new NotAuthenticatedException();
            }

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

        public void Dispose()
        {
            if (!_disposed)
            {
                _httpClient?.Dispose();
                _httpClientHandler?.Dispose();
                _disposed = true;
            }
        }
    }
}
