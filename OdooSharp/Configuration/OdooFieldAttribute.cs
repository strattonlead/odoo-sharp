using System;

namespace OdooSharp.Configuration
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class OdooFieldAttribute : Attribute
    {
        public string FieldName { get; }

        public OdooFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }
    }
}
