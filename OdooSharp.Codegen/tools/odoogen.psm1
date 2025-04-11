function OdooGen-Generate {
    param(
        [string]$Model,
        [switch]$All,
        [string]$Output = "./OdooModels"
    )
    dotnet odoogen generate --model $Model --all:$All --output $Output
}

function OdooGen-Check {
    dotnet odoogen check
}

function OdooGen-Init {
    dotnet odoogen init
}

function OdooGen-Version {
    dotnet odoogen --version
}

function OdooGen-Help {
    @"
OdooGen CLI - Odoo Model Code Generator

Available Commands:
  OdooGen-Generate   Generates model classes
      -Model <name>      Name of a specific Odoo model
      -All               Generate all available models
      -Output <path>     Output directory (default: ./OdooModels)

  OdooGen-Check      Tests the connection to the configured Odoo server
  OdooGen-Init       Creates a .env file for configuration
  OdooGen-Version    Displays the installed version

Usage Examples:
  OdooGen-Init
  OdooGen-Check
  OdooGen-Generate -Model res.partner
  OdooGen-Generate -All -Output ./Generated

"@ | Write-Host
}