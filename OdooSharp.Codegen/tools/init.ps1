$module = Join-Path $PSScriptRoot "odoogen.psm1"
if (Test-Path $module) {
    Import-Module $module -Force
    Write-Host "✅ OdooGen PowerShell-Befehle were load. (Try: OdooGen-Help)"
    Write-Host "To install the cli type 'dotnet tool install --global --add-source ./bin/Release CreateIf.OdooSharp.Codegen'"
} else {
    Write-Warning "⚠️ OdooGen-Modul nicht gefunden!"
}