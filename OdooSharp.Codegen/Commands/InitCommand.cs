using System;
using System.CommandLine;
using System.IO;

namespace OdooSharp.Codegen.Commands
{
    public class InitCommand : Command
    {
        public InitCommand() : base("init", "Creates a .env file for configuration")
        {
            this.SetHandler(() =>
            {
                var file = ".env";
                if (File.Exists(file))
                {
                    Console.WriteLine("⚠️ .env file already exists.");
                    return;
                }

                File.WriteAllText(file,
    @"ODOO_CLIENT_URL=https://yourcompany.odoo.com
ODOO_CLIENT_DATABASE=yourdb
ODOO_CLIENT_USERNAME=admin
ODOO_CLIENT_PASSWORD=securepassword");
                Console.WriteLine("✅ .env file created. Fill in your credentials!");
            });
        }
    }
}
