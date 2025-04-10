using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdooSharp.Configuration
{
    public class OdooFlexibleStringConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType switch
            {
                JsonTokenType.String => reader.GetString(),
                JsonTokenType.Null => null,
                JsonTokenType.False => null,
                JsonTokenType.Number => reader.GetDouble().ToString(), // optional: treat numbers as strings
                _ => throw new JsonException($"Cannot convert token of type {reader.TokenType} to string.")
            };
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(value);
            else
                writer.WriteNullValue();
        }
    }
}
