using OdooSharp.Client;
using OdooSharp.Configuration;
using Sprache;
using System;
using System.CommandLine;
using System.Linq;

namespace OdooSharp.Codegen.Commands
{
    public class ListCommand : Command
    {
        public ListCommand()
            : base("list", "Lists avaibale Odoo model classes")
        {
            var modelFilter = new Option<string>("--filter", "Fulltext name filter (optional)");

            AddOption(modelFilter);

            this.SetHandler(async (string filter) =>
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
                if (!isValid)
                {
                    Console.WriteLine("❌ Failed to connect. Abort generation!");
                    return;
                }

                var allModels = await client.GetModelsAsync();
                var filteredModels = allModels.OrderBy(x => x.Id).ToList();
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    filteredModels = allModels.Where(x => x.Name.Contains(filter) || x.Model.Contains(filter)).ToList();
                }
                Console.WriteLine($"Found {filteredModels.Count} models.");

                foreach (var model in filteredModels)
                {
                    Console.WriteLine($"ID: {model.Id} Name: {model.Name} Model: {model.Model}");
                }
            }, modelFilter);
        }
    }
}
