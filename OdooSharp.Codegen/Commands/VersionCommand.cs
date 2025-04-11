using System;
using System.CommandLine;
using System.Reflection;

namespace OdooSharp.Codegen.Commands
{
    public class VersionCommand : Command
    {
        public VersionCommand() : base("version", "Displays the installed version of odoogen")
        {
            this.SetHandler(() =>
            {
                var version = Assembly
                    .GetExecutingAssembly()
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                    .InformationalVersion ?? "unknown";

                Console.WriteLine($"odoogen v{version}");
            });
        }
    }
}
