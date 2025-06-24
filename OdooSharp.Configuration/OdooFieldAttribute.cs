using System;

namespace OdooSharp.Configuration
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class OdooFieldAttribute : Attribute
    {
        public string FieldName { get; }
        public bool IsReadonly { get; }

        public OdooFieldAttribute(string fieldName, bool isReadonly = false)
        {
            FieldName = fieldName;
            IsReadonly = isReadonly;
        }
    }
}
