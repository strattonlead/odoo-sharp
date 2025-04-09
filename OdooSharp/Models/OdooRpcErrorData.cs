using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    public class OdooRpcErrorData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("debug")]
        public string Debug { get; set; }
    }
}
