$module = Join-Path $PSScriptRoot "odoogen.psm1"
if (Test-Path $module) {
    Import-Module $module -Force
    Write-Host "✅ OdooGen PowerShell-Befehle wurden geladen. (Try: OdooGen-Help)"
} else {
    Write-Warning "⚠️ OdooGen-Modul nicht gefunden!"
}