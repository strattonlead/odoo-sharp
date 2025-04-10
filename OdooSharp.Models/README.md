# OdooSharp JSON-RPC C# ORM Client

A type-safe, extensible C# client for interacting with the Odoo JSON-RPC API.  
Supports full CRUD, filtering, paging, and model-level attributes for clean data access.

---

## 🚀 Features

- 🔐 Auth via JSON-RPC (`/web/session/authenticate`)
- 🔍 Generic `search_read` with domain, fields, paging, sorting
- 🆕 `create`, ✏️ `write`, 🗑️ `unlink`, 📥 `read` (by ID)
- 🧠 Model-level `[OdooModel(...)]` attribute for smart mapping
- 🔄 Paged queries
- ✅ Typed response classes via `System.Text.Json`

---

## 📦 Installation

Just include the nuget package `CreateIf.Odoo` and your typed model classes into your project.  
Requires .netstandard2.1 or compatible with `HttpClient`, `System.Text.Json`.

---

## 🛠️ Configuration

```csharp
var options = new OdooClientOptions
{
    Url = "https://your-odoo-instance.odoo.com",
    Database = "your-database-name",
    Username = "your-user@example.com",
    Password = "your-password"
};

var client = new OdooClient(options);
```

## 🧪 Usage

```csharp
var client = new OdooClient(new OdooClientOptions
{
    Url = "https://your-odoo-url.odoo.com",
    Database = "your-db",
    Username = "you@example.com",
    Password = "your-password"
});

if (await client.AuthenticateAsync())
{
    Console.WriteLine("Authenticated.");

    var models = await client.GetModelsAsync();

    // you can use your custom defined models too
    var quotes = await client.SearchReadAsync<Lieferangebot>(
        model: "x_lieferangebot",
        domain: new object[] { new object[] { "x_status", "=", "offen" } },
        fields: new[] { "x_name", "x_preis", "x_status" },
        limit: 100
    );
}
else
{
    Console.WriteLine("Authentication failed.");
}
```

The custom model class

```csharp
[OdooModel("x_lieferangebot", "[[\"x_status\", \"=\", \"offen\"]]")]
public class Lieferangebot
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("x_name")]
    public string Name { get; set; }

    [JsonPropertyName("x_preis")]
    public float Preis { get; set; }

    [JsonPropertyName("x_status")]
    public string Status { get; set; }
}
```