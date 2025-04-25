using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    public abstract class JsonRpcResponse
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("error")]
        public OdooRpcError Error { get; set; }
    }
    public class JsonRpcResponse<T> : JsonRpcResponse
    {
        [JsonPropertyName("result")]
        public T Result { get; set; }

        public JsonRpcResponse<TResult> First<TResult>()
        {
            var collection = Result as IEnumerable;
            if (collection != null)
            {
                foreach (TResult first in collection)
                {
                    return new JsonRpcResponse<TResult>
                    {
                        JsonRpc = JsonRpc,
                        Id = Id,
                        Error = Error,
                        Result = first
                    };
                }
            }
            return new JsonRpcResponse<TResult>
            {
                JsonRpc = JsonRpc,
                Id = Id,
                Error = Error
            };
        }
    }

    public static class JsonRpcResponseExtensions
    {
        public static JsonRpcResponse<TResult> FirstOrDefault<TResult>(this JsonRpcResponse<List<TResult>> response)
            => new JsonRpcResponse<TResult>
            {
                JsonRpc = response.JsonRpc,
                Id = response.Id,
                Result = response.Result != null ? response.Result.FirstOrDefault() : default,
                Error = response.Error
            };


    }
}
