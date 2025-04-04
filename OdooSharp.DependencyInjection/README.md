# OdooSharp JSON-RPC C# ORM Client

A type-safe, extensible C# client for interacting with the Odoo JSON-RPC API.  
Supports full CRUD, filtering, paging, and model-level attributes for clean data access.

See the core package for usage.

---

## 📦 Installation

Just include the nuget package `CreateIf.Odoo.DependencyInjection` and your typed model classes into your project.  
Requires .netstandard2.1 or compatible with `HttpClient`, `System.Text.Json`.

---

## 🛠️ Configuration

Add the client to your service collection.

```csharp

services.AddOdooClient(options => options
                .UseUrl("https://your-odoo-instance.odoo.com")
                .UseDatabase("your-database-name")
                .UseCredentials("your-user@example.com", "your-password"));
```