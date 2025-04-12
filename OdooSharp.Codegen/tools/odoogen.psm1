$__OdooGenDll = Join-Path (Get-Package CreateIf.OdooSharp.Codegen).InstallPath "tools/netstandard2.1/OdooSharp.Codegen.dll"

# Helper to invoke CLI
function Invoke-OdooGen {
    param (
        [string[]]$Arguments
    )
    & dotnet $__OdooGenDll @Arguments
}

function OdooGen-Generate {
    param(
        [string]$Model,
        [switch]$All,
        [string]$Output = "./OdooModels"
    )

    $args = @("generate")
    if ($Model) {
        $args += @("--model", $Model)
    }
    if ($All) {
        $args += "--all"
    }
    if ($Output) {
        $args += @("--output", $Output)
    }

    Invoke-OdooGen -Arguments $args
}

function OdooGen-Check {
    Invoke-OdooGen -Arguments @("check")
}

function OdooGen-Init {
    Invoke-OdooGen -Arguments @("init")
}

function OdooGen-Version {
    Invoke-OdooGen -Arguments @("--version")
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

Export-ModuleMember -Function OdooGen-Generate, OdooGen-Check, OdooGen-Init, OdooGen-Version, OdooGen-Help