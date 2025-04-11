using OdooSharp.Client;
using OdooSharp.Configuration;
using OdooSharp.Models;
using Sprache;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;

namespace OdooSharp.Codegen.Commands
{
    public class GenerateCommand : Command
    {
        public GenerateCommand()
            : base("generate", "Generates Odoo model classes")
        {
            var modelOption = new Option<string>("--model", "Odoo model to generate");
            var allOption = new Option<bool>("--all", "Generate all models");
            var outputOption = new Option<string>("--output", () => "./OdooModels", "Output folder");

            AddOption(modelOption);
            AddOption(allOption);
            AddOption(outputOption);

            this.SetHandler(async (string model, bool all, string output) =>
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
                var generateModels = new List<OdooModel>();
                if (all)
                {
                    generateModels = allModels;
                }
                else
                {
                    generateModels = allModels.Where(x => x.Model == model).ToList();
                }

                foreach (var generateModel in generateModels)
                {
                    var fields = await client.GetModelFieldsTypedAsync(generateModel.Model);
                    var code = OdooModelGenerator.GenerateCSharpClass(generateModel.Model, fields.Fields);
                    var path = Path.Combine(output, $"{OdooModelGenerator.ToPascalCase(generateModel.Model)}.cs");
                    File.WriteAllText(path, code);
                    Console.WriteLine($"Saved model to {path}.");
                }
            }, modelOption, allOption, outputOption);
        }
    }
}
