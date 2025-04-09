using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdooSharp.Configuration
{
    public class OdooMany2OneIdConverter : JsonConverter<int?>
    {
        public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType switch
            {
                JsonTokenType.Number => reader.GetInt32(),

                JsonTokenType.String => _parse(reader),

                JsonTokenType.False => null,

                JsonTokenType.Null => null,

                JsonTokenType.StartArray => ReadFromArray(ref reader),

                _ => throw new JsonException($"Unexpected token {reader.TokenType} for many2one field.")
            };
        }

        private int? _parse(Utf8JsonReader reader)
        {
            if (int.TryParse(reader.GetString(), out var result))
            {
                return result;
            }
            return null;
        }

        private int? ReadFromArray(ref Utf8JsonReader reader)
        {
            reader.Read(); // move to first element

            int? id;
            if (reader.TokenType == JsonTokenType.String)
            {
                id = _parse(reader);
            }
            else if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected integer ID as first element in many2one array.");
            }
            else
            {
                id = reader.GetInt32();
            }

            // skip second value ("Display Name")
            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray) { }

            return id;
        }

        public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
            else
                writer.WriteNullValue();
        }
    }
}
