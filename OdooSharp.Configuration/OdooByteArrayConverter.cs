using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdooSharp.Configuration
{
    public class OdooByteArrayConverter : JsonConverter<byte[]>
    {
        public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType switch
            {
                JsonTokenType.String => Convert.FromBase64String(reader.GetString()),
                JsonTokenType.Null => null,
                JsonTokenType.False => null, // Odoo's "null" shortcut
                JsonTokenType.StartObject => null,
                _ => throw new JsonException($"Unexpected token type {reader.TokenType} for byte[]. Expected base64 string, null, or false.")
            };
        }

        public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(Convert.ToBase64String(value));
            else
                writer.WriteNullValue();
        }
    }
}
