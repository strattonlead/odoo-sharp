using System;

namespace OdooSharp.Configuration
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class OdooModelAttribute : Attribute
    {
        public string ModelName { get; }
        public string DomainJson { get; }

        public OdooModelAttribute(string modelName, string? domainJson = null)
        {
            ModelName = modelName;
            DomainJson = domainJson;
        }
    }
}
