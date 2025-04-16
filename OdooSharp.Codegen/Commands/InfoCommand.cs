using OdooSharp.Client;
using OdooSharp.Configuration;
using System;
using System.CommandLine;
using System.Linq;

namespace OdooSharp.Codegen.Commands
{
    public class InfoCommand : Command
    {
        public InfoCommand()
            : base("info", "Lists avaibale Odoo model classes")
        {
            var modelParameter = new Option<string>("--model", "The name of the model");

            AddOption(modelParameter);

            this.SetHandler(async (string model) =>
            {
                if (string.IsNullOrWhiteSpace(model))
                {
                    Console.WriteLine("Please use the --model argument and pass the model name (e.g. res.partner)");
                    return;
                }

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
                var odooModel = allModels.FirstOrDefault(x => x.Model == model);

                if (odooModel == null)
                {
                    Console.WriteLine($"Model {model} was not found.");
                }
                else
                {
                    var className = OdooModelGenerator.ToPascalCase(odooModel.Model.Replace(".", "_"));
                    Console.WriteLine($"Class: {className}");

                    var fieldResponse = await client.GetModelFieldsTypedAsync(odooModel.Model);
                    foreach (var field in fieldResponse.Fields)
                    {

                        Console.WriteLine($"- Internal field: {field.Value.Name} Label: {field.Value.Label} Field type: {field.Value.FieldType} Required: {field.Value.Required} Readonly: {field.Value.Readonly}");
                    }
                }

            }, modelParameter);
        }
    }
}
