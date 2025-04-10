using System;
using System.Text.Json.Serialization;

namespace OdooSharp.Client
{
    public abstract class OdooRpcRequest
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc => "2.0";

        [JsonPropertyName("method")]
        public string Method => "call";

        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }

    public class OdooRpcRequest<TParams> : OdooRpcRequest
    {
        [JsonPropertyName("params")]
        public TParams Params { get; set; }
    }
}
