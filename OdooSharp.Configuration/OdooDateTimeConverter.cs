using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdooSharp.Configuration
{
    public class OdooDateTimeConverter : JsonConverter<DateTime?>
    {
        private static readonly string[] Formats = new[]
        {
        "yyyy-MM-dd HH:mm:ss",      // Most common from Odoo
        "yyyy-MM-dd",               // Date only
        "yyyy-MM-ddTHH:mm:ss",      // ISO format
        "yyyy-MM-ddTHH:mm:ssZ",     // ISO with Zulu
        "yyyy-MM-ddTHH:mm:ss.fffZ", // ISO with ms
        "yyyy-M-d", // ISO with ms
    };

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType is JsonTokenType.Null || reader.TokenType is JsonTokenType.False)
                return null;

            if (reader.TokenType == JsonTokenType.String)
            {
                var str = reader.GetString()?.Trim();

                if (string.IsNullOrWhiteSpace(str) || str == "1-01-01" || str == "0001-01-01")
                    return null;

                if (DateTime.TryParseExact(str, Formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
                    return result;

                throw new JsonException($"Invalid date format: {str}");
            }

            throw new JsonException($"Unexpected token {reader.TokenType} for DateTime");
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(value.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            else
                writer.WriteNullValue();
        }
    }
}
