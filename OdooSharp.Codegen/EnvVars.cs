using DotNetEnv;
using System;

namespace OdooSharp.Codegen
{
    public class EnvVars
    {
        public EnvVars()
        {
            Env.TraversePath().Load();
        }

        public string Database => Environment.GetEnvironmentVariable("ODOO_CLIENT_DATABASE") ?? throw new ArgumentException("Env var ODOO_CLIENT_DATABASE not set");
        public string Username => Environment.GetEnvironmentVariable("ODOO_CLIENT_USERNAME") ?? throw new ArgumentException("Env var ODOO_CLIENT_USERNAME not set");
        public string Password => Environment.GetEnvironmentVariable("ODOO_CLIENT_PASSWORD") ?? throw new ArgumentException("Env var ODOO_CLIENT_PASSWORD not set");
        public string Url => Environment.GetEnvironmentVariable("ODOO_CLIENT_URL") ?? throw new ArgumentException("Env var ODOO_CLIENT_URL not set");

    }
}
