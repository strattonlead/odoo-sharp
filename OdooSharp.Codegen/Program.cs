// See https://aka.ms/new-console-template for more information
using OdooSharp.Client;
using OdooSharp.Codegen;


var client = new OdooClient(new OdooSharp.Configuration.OdooClientOptions()
{

});

Console.WriteLine("Authenticate...");
await client.AuthenticateAsync();
Console.WriteLine("Authenticated!");

//var resp = await client.SearchReadAsync<AccountAccount>();
//var single = await client.GetByIdAsync<AccountAccount>(resp.Result.First().Id);

//var attrType = typeof(OdooModelAttribute);
//var modelTypes = typeof(AccountAccount).Assembly.GetTypes().Where(x => x.GetCustomAttributes(false).Any(y => y.GetType() == attrType)).Except(new Type[] { typeof(OdooModel) }).ToArray();

//for (var i = 0; i < modelTypes.Length; i++)
//{
//    var modelType = modelTypes[i];
//    Console.WriteLine($"Test model {modelType.Name} ({i + 1}/{modelTypes.Length})...");

//    var mi = client.GetType().GetMethods().FirstOrDefault(x => x.Name == "SearchReadAsync").MakeGenericMethod(modelType);
//    var task = mi.Invoke(client, new object[] { null, null, 100, 0, null }) as Task;
//    var result = await OdooFieldMapper.AwaitAndUnwrapTaskAsync(task);
//    var response = result as JsonRpcResponse;
//    if (response == null)
//    {
//        Console.WriteLine($"Error: response is null");
//        continue;
//    }
//    if (response.Error != null)
//    {
//        Console.WriteLine($"Error: {response.Error.Message}");
//    }
//    else
//    {
//        Console.WriteLine("Fetch ok!");
//    }

//}

Console.WriteLine();
Console.WriteLine("GetModelsAsync...");
var models = await client.GetModelsAsync();
Console.WriteLine($"Models {models.Count}");
Console.WriteLine();
Directory.CreateDirectory("gen");

for (var i = 0; i < models.Count; i++)
{
    var model = models[i];
    Console.WriteLine($"Process model {model.Model} ({i + 1}/{models.Count})...");

    var fields = await client.GetModelFieldsTypedAsync(model.Model);
    var code = OdooModelGenerator.GenerateCSharpClass(model.Model, fields.Fields);
    File.WriteAllText($"gen/{OdooModelGenerator.ToPascalCase(model.Model)}.cs", code);
    Console.WriteLine($"Saved model to gen/{OdooModelGenerator.ToPascalCase(model.Model)}.cs");
}
