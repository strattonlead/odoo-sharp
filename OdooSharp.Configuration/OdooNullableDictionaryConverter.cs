using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdooSharp.Configuration
{
    public class OdooNullableDictionaryConverter : JsonConverter<Dictionary<string, object>>
    {
        public override Dictionary<string, object> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType switch
            {
                JsonTokenType.Null => null,
                JsonTokenType.False => null,

                JsonTokenType.StartObject => JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options),

                _ => throw new JsonException($"Unexpected token {reader.TokenType} when expecting Dictionary<string, object>")
            };
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<string, object> value, JsonSerializerOptions options)
        {
            if (value == null)
                writer.WriteNullValue();
            else
                JsonSerializer.Serialize(writer, value, options);
        }
    }
}
