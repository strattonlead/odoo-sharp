using System;

namespace OdooSharp.Configuration.EnvironmentVariables
{
    public static class OdooClientOptionsBuilderExtensions
    {
        /// <summary>
        /// Your environment variables must provide these 4 environment variables!
        /// <para>ODOO_CLIENT_URL</para>
        /// <para>ODOO_CLIENT_DATABASE</para>
        /// <para>ODOO_CLIENT_USERNAME</para>
        /// <para>ODOO_CLIENT_PASSWORD</para>
        /// </summary>
        public static OdooClientOptionsBuilder UseEnvironmentVariables(this OdooClientOptionsBuilder builder)
        {
            builder.UseDatabase(Environment.GetEnvironmentVariable("ODOO_CLIENT_DATABASE") ?? throw new ArgumentException("Environment variable 'ODOO_CLIENT_DATABASE' is missing!"));
            builder.UseUrl(Environment.GetEnvironmentVariable("ODOO_CLIENT_URL") ?? throw new ArgumentException("Environment variable 'ODOO_CLIENT_URL' is missing!"));
            builder.UseCredentials(Environment.GetEnvironmentVariable("ODOO_CLIENT_USERNAME") ?? throw new ArgumentException("Environment variable 'ODOO_CLIENT_USERNAME' is missing!"),
                Environment.GetEnvironmentVariable("ODOO_CLIENT_PASSWORD") ?? throw new ArgumentException("Environment variable 'ODOO_CLIENT_PASSWORD' is missing!"));
            return builder;
        }
    }
}