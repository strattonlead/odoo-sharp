# 🧩 OdooGen – Odoo Model Code Generator for .NET

**OdooGen** is a .NET CLI & PowerShell tool that helps you generate **strongly-typed C# model classes** from Odoo metadata via the RPC API.

Use it in microservices or backend integrations — works perfectly with **Odoo SaaS (Cloud)** and **On-Premise** environments.

## ✨ Features

- 🔁 Generate classes for **one or all Odoo models**
- ✅ Nullable and typed properties
- ⚡ Works without Python modules or Odoo addons
- 🧪 PowerShell integration for Visual Studio
- 🧰 Supports `.env`-based configuration
- 🧱 Designed for clean CI/CD usage (e.g. GitHub Actions)

## 📦 Installation

### 🔹 Option 1 – .NET Global Tool

```bash
dotnet tool install --global CreateIf.OdooSharp.Codegen
```

Make sure ~/.dotnet/tools is in your PATH.

### 🔹 Option 2 – NuGet Package (Visual Studio + PowerShell) *(preferred)*

```powershell
Install-Package CreateIf.OdooSharp.Codegen
```

Registers OdooGen-* commands in Package Manager Console.

## ⚙️ Quickstart

### 1. Initialize config

```powershell
OdooGen-Init
```

Creates a .env file with:

```ini
ODOO_CLIENT_URL=https://your.odoo.server
ODOO_CLIENT_DB=your-database
ODOO_CLIENT_USERNAME=your-email@example.com
ODOO_CLIENT_PASSWORD=your-password
```

## 🔧 PowerShell Commands (PMC)

| Command               | Description                             |
|-----------------------|-----------------------------------------|
| `OdooGen-Init`        | Creates `.env` configuration file       |
| `OdooGen-Check`       | Tests Odoo server & authentication      |
| `OdooGen-Generate`    | Generates model class files             |
| `OdooGen-Version`     | Displays the installed version          |
| `OdooGen-Help`        | Shows CLI usage overview                |

### 🔹 Examples

```powershell
# Initialize config
OdooGen-Init

# Check connection
OdooGen-Check

# Generate single model
OdooGen-Generate -Model res.partner

# Generate all models to a specific folder
OdooGen-Generate -All -Output ./Generated
```

### 💻 CLI Usage (dotnet tool)

If installed via dotnet tool, you can use:

```bash
dotnet odoogen init
dotnet odoogen check
dotnet odoogen generate --model res.partner
dotnet odoogen generate --all --output ./Generated
dotnet odoogen --version
```