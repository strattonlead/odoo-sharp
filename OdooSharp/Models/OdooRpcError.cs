using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    public class OdooRpcError
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public OdooRpcErrorData Data { get; set; }
    }
}
