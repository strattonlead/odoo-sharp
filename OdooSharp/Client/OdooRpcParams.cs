using System.Text.Json.Serialization;

namespace OdooSharp.Client
{
    public class OdooRpcParams
    {
        [JsonPropertyName("service")]
        public string Service { get; set; }

        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("args")]
        public object[] Args { get; set; }
    }
}
