using OdooSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdooSharp.Codegen
{
    public class OdooModelGenerator
    {
        public static string GenerateCSharpClass(string modelName, string @namespace, Dictionary<string, OdooField> fields)
        {
            var classNameMappings = GetMappings();
            classNameMappings.TryGetValue(modelName, out var mapping);

            @namespace = @namespace ?? mapping?.Namespace ?? "OdooSharp.Models";
            var className = mapping?.ClassName ?? GetClassName(modelName, classNameMappings);

            var sb = new StringBuilder();

            sb.AppendLine("using OdooSharp.Configuration;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Text.Json.Serialization;");
            sb.AppendLine();
            sb.AppendLine($"namespace {@namespace}");
            sb.AppendLine("{");

            sb.AppendLine($"    [OdooModel(\"{modelName}\")]");
            sb.AppendLine("    public partial class " + className);
            sb.AppendLine("    {");

            var yes = "yes";
            var no = "no";

            foreach (var pair in fields)
            {
                var field = pair.Value;

                var csharpType = OdooFieldMapper.MapToCSharpType(field, modelName);
                mapping.PropertyMappingsDict.TryGetValue(pair.Key, out var propertyMapping);
                var propertyName = propertyMapping?.PropertyName ?? ToPascalCase(pair.Key);

                sb.AppendLine($"        /// <summary>");
                sb.AppendLine($"        /// <para>Name: {field.Label}</para>");
                sb.AppendLine($"        /// <para>Internal: {field.Name}</para>");
                sb.AppendLine($"        /// <para>Store: {(field.Store ? yes : no)}</para>");
                sb.AppendLine($"        /// <para>Required: {(field.Required ? yes : no)}</para>");
                sb.AppendLine($"        /// <para>Readonly: {(field.Readonly ? yes : no)}</para>");
                sb.AppendLine($"        /// <para>Company Dependent: {(field.CompanyDependent ? yes : no)}</para>");
                sb.AppendLine($"        /// <para>Field type: {field.FieldType}</para>");

                if (field.Selection is JsonElement)
                {
                    var selection = (JsonElement)field.Selection;
                    if (selection.ValueKind == JsonValueKind.Array)
                    {
                        var values = new StringBuilder();
                        foreach (var option in selection.EnumerateArray())
                        {
                            if (option.ValueKind == JsonValueKind.Array && option.GetArrayLength() == 2)
                            {
                                var valueElement = option[0];
                                var labelElement = option[1];

                                string value = valueElement.GetString();
                                string label = labelElement.GetString();

                                values.Append($"[{value}]={label},");
                            }
                        }

                        if (values.Length > 1)
                        {
                            values.Length--;
                        }

                        sb.AppendLine($"        /// <para>Allowed selection values: {values}</para>");

                    }
                }


                if (!string.IsNullOrWhiteSpace(field.Relation))
                {
                    sb.AppendLine($"        /// <para>Relation: {field.Relation}</para>");
                }
                sb.AppendLine($"        /// </summary>");

                sb.AppendLine($"        [JsonPropertyName(\"{pair.Key}\")]");
                if (field.FieldType == OdooFieldType.Many2One)
                {
                    sb.AppendLine($"        [JsonConverter(typeof(OdooMany2OneIdConverter))]");
                }
                else if (field.FieldType == OdooFieldType.Text
                    || field.FieldType == OdooFieldType.Char
                    || field.FieldType == OdooFieldType.Html
                    || field.FieldType == OdooFieldType.Url
                    || field.FieldType == OdooFieldType.Selection
                    || field.FieldType == OdooFieldType.Reference)
                {
                    sb.AppendLine($"        [JsonConverter(typeof(OdooFlexibleStringConverter))]");
                }
                else if (field.FieldType == OdooFieldType.DateTime || field.FieldType == OdooFieldType.Date)
                {
                    sb.AppendLine($"        [JsonConverter(typeof(OdooDateTimeConverter))]");
                }
                else if (csharpType == "byte[]")
                {
                    sb.AppendLine($"        [JsonConverter(typeof(OdooByteArrayConverter))]");
                }
                else if (csharpType == "object")
                {
                    sb.AppendLine($"        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]");
                }

                sb.AppendLine($"        [OdooField(\"{field.Name}\", {field.Readonly.ToString().ToLower()})]");
                sb.AppendLine($"        public {csharpType} {propertyName} {{ get; set; }}");
                sb.AppendLine();
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }

        //public static string ToPascalCase(string input)
        //{
        //    return string.Concat(input.Split('_', '.')
        //        .Select(part => char.ToUpper(part[0]) + part.Substring(1)));
        //}

        public static Dictionary<string, ClassNameMapping> GetMappings()
        {
            Dictionary<string, ClassNameMapping> classNameMappings = new Dictionary<string, ClassNameMapping>();
            var genMapFile = ".odoogen-map";
            if (File.Exists(genMapFile))
            {
                var text = File.ReadAllText(genMapFile);
                classNameMappings = JsonSerializer.Deserialize<ClassNameMapping[]>(text).ToDictionary(x => x.ModelName);
            }
            return classNameMappings;
        }

        public static string GetClassName(string modelName)
        {
            var classNameMappings = GetMappings();
            var className = ToPascalCase(modelName.Replace(".", "_"));
            if (classNameMappings.TryGetValue(modelName, out var mapping))
            {
                className = mapping.ClassName;
            }

            return className;
        }

        public static string GetClassName(string modelName, Dictionary<string, ClassNameMapping> classNameMappings)
        {
            var className = ToPascalCase(modelName.Replace(".", "_"));
            if (classNameMappings.TryGetValue(modelName, out var mapping))
            {
                className = mapping.ClassName;
            }

            return className;
        }

        public static string ToPascalCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            bool isPrivate = input.StartsWith("_");
            if (!isPrivate)
            {
                return string.Concat(input.Split('_', '.')
                .Select(part => char.ToUpper(part[0]) + part.Substring(1)));
            }
            var parts = input.TrimStart('_').Split('_', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0)
                return input;

            // Erste Komponente klein schreiben (camelCase) für private Felder
            var first = parts[0].Substring(0, 1).ToLower() + parts[0].Substring(1);

            var rest = parts.Skip(1)
                .Select(Capitalize);

            var result = first + string.Concat(rest);
            return isPrivate ? "_" + result : result;
        }

        private static string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            return char.ToUpper(s[0]) + s.Substring(1);
        }



        public class ClassNameMapping
        {
            [JsonPropertyName("model_name")]
            public string ModelName { get; set; }

            [JsonPropertyName("class_name")]
            public string ClassName { get; set; }

            [JsonPropertyName("namespace")]
            public string Namespace { get; set; }

            [JsonPropertyName("property_mappings")]
            public List<PropertyNameMapping> PropertyMappings { get; set; }

            [JsonIgnore]
            public Dictionary<string, PropertyNameMapping> PropertyMappingsDict => PropertyMappings?.GroupBy(x => x.FieldName).Select(x => x.First()).ToDictionary(x => x.FieldName) ?? new Dictionary<string, PropertyNameMapping>();
        }

        public class PropertyNameMapping
        {
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; }

            [JsonPropertyName("property_name")]
            public string PropertyName { get; set; }
        }
    }
}
