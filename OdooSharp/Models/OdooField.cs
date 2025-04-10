using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    public class OdooField
    {
        /// <summary>
        /// Indicates whether the field supports user-defined default values.
        /// If true, users can set their own default which applies when creating new records.
        /// </summary>
        [JsonPropertyName("change_default")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool ChangeDefault { get; set; }

        /// <summary>
        /// Specifies whether the field's value can vary by company (multi-company environment).
        /// If true, each company may store its own value for the field.
        /// </summary>
        [JsonPropertyName("company_dependent")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool CompanyDependent { get; set; }

        /// <summary>
        /// Used only with monetary fields. Defines the name of the field
        /// that determines the currency (e.g., "currency_id" or "company_currency_id").
        /// </summary>
        [JsonPropertyName("currency_field")]
        public string CurrencyField { get; set; }

        /// <summary>
        /// Indicates whether the field is compatible with Odoo's legacy export format.
        /// Mostly relevant for older systems or tools relying on deprecated export mechanisms.
        /// </summary>
        [JsonPropertyName("default_export_compatible")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool DefaultExportCompatible { get; set; }

        /// <summary>
        /// Lists field names that this field depends on for computation.
        /// Used with computed fields (`@api.depends`) to track field dependencies.
        /// </summary>
        [JsonPropertyName("depends")]
        public List<string> Depends { get; set; }

        /// <summary>
        /// Determines whether the field is available in the export wizard UI.
        /// If false, users cannot include this field in standard exports.
        /// </summary>
        [JsonPropertyName("exportable")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool Exportable { get; set; }

        /// <summary>
        /// Indicates whether this field can be used in group-by clauses (e.g., in reports or list views).
        /// </summary>
        [JsonPropertyName("groupable")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool Groupable { get; set; }

        /// <summary>
        /// Technical/internal flag, rarely used in public models.
        /// Usually true for manually created fields or metadata-driven ones.
        /// </summary>
        [JsonPropertyName("manual")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool Manual { get; set; }

        /// <summary>
        /// The internal technical name of the field (used in API calls like search, read, or write).
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the field is read-only in the UI.
        /// Users cannot manually edit a read-only field unless overridden in views.
        /// </summary>
        [JsonPropertyName("readonly")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool Readonly { get; set; }

        /// <summary>
        /// Whether the field is mandatory in form views or during record creation.
        /// A required field cannot be empty or null.
        /// </summary>
        [JsonPropertyName("required")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool Required { get; set; }

        /// <summary>
        /// Specifies whether this field is searchable in the UI (filter/search bars).
        /// </summary>
        [JsonPropertyName("searchable")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool Searchable { get; set; }

        /// <summary>
        /// Determines if the field can be sorted by in list/tree views.
        /// </summary>
        [JsonPropertyName("sortable")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool Sortable { get; set; }


        /// <summary>
        /// Indicates whether the value of this field is stored in the database.
        /// If false, the value is computed dynamically at runtime and not persisted.
        /// </summary>
        [JsonPropertyName("store")]
        [JsonConverter(typeof(OdooFlexibleBoolConverter))]
        public bool Store { get; set; }

        /// <summary>
        /// The user-friendly label of the field as shown in the UI.
        /// </summary>
        [JsonPropertyName("string")]
        public string Label { get; set; }

        /// <summary>
        /// For relational fields, specifies the related model (e.g., 'res.partner').
        /// </summary>
        [JsonPropertyName("relation")]
        public string Relation { get; set; }

        /// <summary>
        /// The technical type of the field as defined in Odoo (e.g., "char", "monetary", "many2one").
        /// This determines how the value is handled and how it should be mapped in code.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFieldTypeConverter))]
        public OdooFieldType FieldType { get; set; }

        /// <summary>
        /// The possible selection keys and values.
        /// </summary>
        [JsonPropertyName("selection")]
        public object Selection { get; set; }
    }

    public class OdooFlexibleBoolConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType switch
            {
                JsonTokenType.True => true,
                JsonTokenType.False => false,
                JsonTokenType.String => bool.TryParse(reader.GetString(), out var result) && result,
                _ => throw new JsonException($"Cannot convert token of type {reader.TokenType} to boolean.")
            };
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteBooleanValue(value);
        }
    }

    public class OdooFieldTypeConverter : JsonConverter<OdooFieldType>
    {
        public override OdooFieldType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string type = reader.GetString()?.ToLowerInvariant();

            return type switch
            {
                "char" => OdooFieldType.Char,
                "text" => OdooFieldType.Text,
                "html" => OdooFieldType.Html,
                "boolean" => OdooFieldType.Boolean,
                "integer" => OdooFieldType.Integer,
                "float" => OdooFieldType.Float,
                "monetary" => OdooFieldType.Monetary,
                "selection" => OdooFieldType.Selection,
                "binary" => OdooFieldType.Binary,
                "date" => OdooFieldType.Date,
                "datetime" => OdooFieldType.DateTime,
                "url" => OdooFieldType.Url,
                "many2one" => OdooFieldType.Many2One,
                "one2many" => OdooFieldType.One2Many,
                "many2many" => OdooFieldType.Many2Many,
                "reference" => OdooFieldType.Reference,
                "json" => OdooFieldType.Json,
                "serialized" => OdooFieldType.Serialized,
                "uuid" => OdooFieldType.Uuid,
                _ => OdooFieldType.Unknown
            };
        }

        public override void Write(Utf8JsonWriter writer, OdooFieldType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString().ToLower());
        }
    }
}
