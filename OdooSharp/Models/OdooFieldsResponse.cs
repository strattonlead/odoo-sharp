using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{


    public class OdooFieldsResponse
    {
        [JsonPropertyName("result")]
        public Dictionary<string, OdooField> Fields { get; set; }
    }
}
