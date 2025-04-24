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
                var genMapFile = ".odoogen-map";
                if (File.Exists(genMapFile))
                {
                    Console.WriteLine("⚠️ .odoogen-map file already exists.");
                }
                else
                {
                    File.WriteAllText(genMapFile, @"[{
        ""model_name"": ""x_odoo_model_name"",
        ""class_name"": ""MyCSharpClassName"",
        ""namespace"": ""My.Namespace"",
        ""property_mappings"": [{
                ""field_name"": ""x_studio_field_name"",
                ""property_name"": ""MyCSharpPropertyName""
            }
        ]
    }
]");
                }

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


