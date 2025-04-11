using OdooSharp.Models;
using System.Threading.Tasks;

namespace OdooSharp.Codegen
{
    public static class OdooFieldMapper
    {
        public static string MapToCSharpType(OdooField field, string modelName)
        {
            /* Custom field overrides */
            if (field.FieldType == OdooFieldType.Binary && modelName == "ir.actions.client" && (field.Name == "params_store" || field.Name == "params"))
            {
                return "object";
            }

            //var required = field.Required ? "" : "?";
            return field.FieldType switch
            {
                OdooFieldType.Char => "string",
                OdooFieldType.Text => "string",
                OdooFieldType.Html => "string",
                OdooFieldType.Url => "string",
                OdooFieldType.Boolean => "bool",
                OdooFieldType.Integer => "int",
                OdooFieldType.Float => "double",
                OdooFieldType.Monetary => "decimal",
                OdooFieldType.Selection => "string",
                OdooFieldType.Many2One => $"int?",
                OdooFieldType.Many2Many => "List<int>",
                OdooFieldType.One2Many => "List<int>",
                OdooFieldType.Date => "DateTime?",
                OdooFieldType.DateTime => "DateTime?",
                OdooFieldType.Binary => _dynamicByteFieldType(field),
                OdooFieldType.Uuid => "Guid",
                OdooFieldType.Reference => "string", // Could be replaced with a wrapper object
                OdooFieldType.Json => "object", // Could be `JObject` or custom DTO
                OdooFieldType.Serialized => "object",
                _ => "object"
            };
        }

        private static string _dynamicByteFieldType(OdooField field)
        {
            bool computedNonStorable = field.Readonly && !field.Store;
            bool looksLikeMap = field.Name.EndsWith("map");

            if (computedNonStorable || looksLikeMap)
                return "object"; // Fallback for non-binary binary fields

            return "byte[]";
        }

        public static async Task<object> AwaitAndUnwrapTaskAsync(Task task)
        {
            await task.ConfigureAwait(false);

            var type = task.GetType();

            var resultProperty = type.GetProperty("Result");
            return resultProperty?.GetValue(task); //
        }
    }
}
