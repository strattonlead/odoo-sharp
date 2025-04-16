using OdooSharp.Codegen.Commands;
using System.CommandLine;
using System.Threading.Tasks;

namespace OdooSharp.Codegen
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var rootCommand = new RootCommand("odoogen CLI tool for generating Odoo models");

            rootCommand.AddCommand(new CheckCommand());
            rootCommand.AddCommand(new InitCommand());
            rootCommand.AddCommand(new ListCommand());
            rootCommand.AddCommand(new InfoCommand());
            rootCommand.AddCommand(new GenerateCommand());
            rootCommand.AddCommand(new VersionCommand());

            return await rootCommand.InvokeAsync(args);
        }
    }
}

//// See https://aka.ms/new-console-template for more information
//using OdooSharp.Client;
//using OdooSharp.Codegen;
//using OdooSharp.Configuration;

//var envVars = new EnvVars();
//var options = new OdooClientOptions()
//{
//    Database = envVars.Database,
//    Username = envVars.Username,
//    Password = envVars.Password,
//    Url = envVars.Url
//};

//var client = new OdooClient(options);

//Console.WriteLine("Authenticate...");
//await client.AuthenticateAsync();
//Console.WriteLine("Authenticated!");

////var resp = await client.SearchReadAsync<AccountAccount>();
////var single = await client.GetByIdAsync<AccountAccount>(resp.Result.First().Id);

////var attrType = typeof(OdooModelAttribute);
////var modelTypes = typeof(AccountAccount).Assembly.GetTypes().Where(x => x.GetCustomAttributes(false).Any(y => y.GetType() == attrType)).Except(new Type[] { typeof(OdooModel) }).ToArray();

////for (var i = 0; i < modelTypes.Length; i++)
////{
////    var modelType = modelTypes[i];
////    Console.WriteLine($"Test model {modelType.Name} ({i + 1}/{modelTypes.Length})...");

////    var mi = client.GetType().GetMethods().FirstOrDefault(x => x.Name == "SearchReadAsync").MakeGenericMethod(modelType);
////    var task = mi.Invoke(client, new object[] { null, null, 100, 0, null }) as Task;
////    var result = await OdooFieldMapper.AwaitAndUnwrapTaskAsync(task);
////    var response = result as JsonRpcResponse;
////    if (response == null)
////    {
////        Console.WriteLine($"Error: response is null");
////        continue;
////    }
////    if (response.Error != null)
////    {
////        Console.WriteLine($"Error: {response.Error.Message}");
////    }
////    else
////    {
////        Console.WriteLine("Fetch ok!");
////    }

////}

//Console.WriteLine();
//Console.WriteLine("GetModelsAsync...");
//var models = await client.GetModelsAsync();
//Console.WriteLine($"Models {models.Count}");
//Console.WriteLine();
//Directory.CreateDirectory("gen");

//for (var i = 0; i < models.Count; i++)
//{
//    var model = models[i];
//    Console.WriteLine($"Process model {model.Model} ({i + 1}/{models.Count})...");

//    var fields = await client.GetModelFieldsTypedAsync(model.Model);
//    var code = OdooModelGenerator.GenerateCSharpClass(model.Model, fields.Fields);
//    File.WriteAllText($"gen/{OdooModelGenerator.ToPascalCase(model.Model)}.cs", code);
//    Console.WriteLine($"Saved model to gen/{OdooModelGenerator.ToPascalCase(model.Model)}.cs");
//}
