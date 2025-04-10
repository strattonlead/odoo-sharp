using DotNetEnv;

namespace OdooSharp.Tests
{
    public class EnvVars
    {
        public EnvVars()
        {
            Env.TraversePath().Load();
        }

        public string Database => Environment.GetEnvironmentVariable("DATABASE") ?? throw new ArgumentException("Env var DATABASE not set");
        public string Username => Environment.GetEnvironmentVariable("USERNAME") ?? throw new ArgumentException("Env var USERNAME not set");
        public string Password => Environment.GetEnvironmentVariable("PASSWORD") ?? throw new ArgumentException("Env var PASSWORD not set");
        public string Url => Environment.GetEnvironmentVariable("URL") ?? throw new ArgumentException("Env var URL not set");

    }
}
