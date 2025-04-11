using OdooSharp.Client;
using OdooSharp.Configuration;
using System;
using System.CommandLine;

namespace OdooSharp.Codegen.Commands
{
    public class CheckCommand : Command
    {
        public CheckCommand() : base("check", "Checks connection to Odoo server")
        {
            this.SetHandler(async () =>
            {
                var envVars = new EnvVars();
                var options = new OdooClientOptions()
                {
                    Database = envVars.Database,
                    Username = envVars.Username,
                    Password = envVars.Password,
                    Url = envVars.Url
                };

                var client = new OdooClient(options);
                var isValid = await client.AuthenticateAsync();
                Console.WriteLine(isValid ? "✅ Connection successful" : "❌ Failed to connect.");
            });
        }
    }
}
