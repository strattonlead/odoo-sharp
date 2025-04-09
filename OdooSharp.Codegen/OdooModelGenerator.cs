using OdooSharp.Models;
using System.Text;

namespace OdooSharp.Codegen
{
    public class OdooModelGenerator
    {
        /// <summary>
        /// <para>Type: many2one</para>
        /// <para>Relation: res.partner</para>
        /// <para>Required: Yes</para>
        /// <para>Readonly: No</para>
        /// </summary>
        public static string GenerateCSharpClass(string modelName, Dictionary<string, OdooField> fields)
        {
            var className = ToPascalCase(modelName.Replace(".", "_"));
            var sb = new StringBuilder();

            sb.AppendLine("using OdooSharp.Configuration;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Text.Json.Serialization;");
            sb.AppendLine();
            sb.AppendLine("namespace OdooSharp.Models");
            sb.AppendLine("{");

            sb.AppendLine($"    [OdooModel(\"{modelName}\")]");
            sb.AppendLine("    public partial class " + className);
            sb.AppendLine("    {");

            var yes = "yes";
            var no = "no";

            foreach (var field in fields)
            {
                var csharpType = OdooFieldMapper.MapToCSharpType(field.Value, modelName);
                var propertyName = ToPascalCase(field.Key);

                sb.AppendLine($"        /// <summary>");
                sb.AppendLine($"        /// <para>Name: {field.Value.Label}</para>");
                sb.AppendLine($"        /// <para>Internal: {field.Value.Name}</para>");
                sb.AppendLine($"        /// <para>Store: {(field.Value.Store ? yes : no)}</para>");
                sb.AppendLine($"        /// <para>Required: {(field.Value.Required ? yes : no)}</para>");
                sb.AppendLine($"        /// <para>Readonly: {(field.Value.Readonly ? yes : no)}</para>");
                sb.AppendLine($"        /// <para>Company Dependent: {(field.Value.CompanyDependent ? yes : no)}</para>");
                sb.AppendLine($"        /// <para>Field type: {field.Value.FieldType}</para>");

                if (!string.IsNullOrWhiteSpace(field.Value.Relation))
                {
                    sb.AppendLine($"        /// <para>Relation: {field.Value.Relation}</para>");
                }
                sb.AppendLine($"        /// </summary>");

                sb.AppendLine($"        [JsonPropertyName(\"{field.Key}\")]");
                if (field.Value.FieldType == OdooFieldType.Many2One)
                {
                    sb.AppendLine($"        [JsonConverter(typeof(OdooMany2OneIdConverter))]");
                }
                else if (field.Value.FieldType == OdooFieldType.Text
                    || field.Value.FieldType == OdooFieldType.Char
                    || field.Value.FieldType == OdooFieldType.Html
                    || field.Value.FieldType == OdooFieldType.Url
                    || field.Value.FieldType == OdooFieldType.Selection
                    || field.Value.FieldType == OdooFieldType.Reference)
                {
                    sb.AppendLine($"        [JsonConverter(typeof(OdooFlexibleStringConverter))]");
                }
                else if (field.Value.FieldType == OdooFieldType.DateTime || field.Value.FieldType == OdooFieldType.Date)
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
    }
}
