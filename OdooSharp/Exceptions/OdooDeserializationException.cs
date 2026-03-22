using System;

namespace OdooSharp.Exceptions
{
    public class OdooDeserializationException : Exception
    {
        public string RawJson { get; }

        public OdooDeserializationException(string rawJson, Exception innerException)
            : base($"Failed to deserialize Odoo JSON-RPC response.", innerException)
        {
            RawJson = rawJson;
        }
    }
}
