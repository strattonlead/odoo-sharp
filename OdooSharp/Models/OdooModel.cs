using OdooSharp.Configuration;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("ir.model")]
    public class OdooModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }
    }
}
