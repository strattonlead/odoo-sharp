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
            var namespaceOption = new Option<string>("--namespace", "Namespace for the generated classes");
            var outputOption = new Option<string>("--output", () => "./OdooModels", "Output folder");

            AddOption(modelOption);
            AddOption(allOption);
            AddOption(namespaceOption);
            AddOption(outputOption);

            this.SetHandler(async (string model, bool all, string @namespace, string output) =>
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
                else if (!string.IsNullOrWhiteSpace(model))
                {
                    generateModels = allModels.Where(x => x.Model == model).ToList();
                }
                else if (OdooModelGenerator.GetMappings().Any())
                {
                    Console.WriteLine($"Use .odoogen-map file.");

                    var mappings = OdooModelGenerator.GetMappings();
                    var models = mappings.Keys.ToList();

                    Console.WriteLine($"{models.Count} models found!");
                    foreach (var definedModel in models)
                    {
                        Console.WriteLine($"- {definedModel}");
                    }

                    generateModels = allModels.Where(x => models.Contains(x.Model)).ToList();
                    Console.WriteLine($"{generateModels.Count} models available for generation!");
                }

                foreach (var generateModel in generateModels)
                {
                    var fields = await client.GetModelFieldsTypedAsync(generateModel.Model);
                    var code = OdooModelGenerator.GenerateCSharpClass(generateModel.Model, @namespace, fields.Fields);
                    var className = OdooModelGenerator.GetClassName(generateModel.Model);
                    var path = Path.Combine(output, $"{className}.cs");
                    File.WriteAllText(path, code);
                    Console.WriteLine($"Saved model to {path}.");
                }
            }, modelOption, allOption, namespaceOption, outputOption);
        }
    }
}
