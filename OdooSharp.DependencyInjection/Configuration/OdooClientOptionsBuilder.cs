namespace OdooSharp.Configuration
{
    public class OdooClientOptionsBuilder
    {
        private readonly OdooClientOptions _options;

        public OdooClientOptionsBuilder()
        {
            _options = new OdooClientOptions();
        }

        public OdooClientOptionsBuilder UseDatabase(string database)
        {
            _options.Database = database;
            return this;
        }

        public OdooClientOptionsBuilder UseUrl(string url)
        {
            _options.Url = url;
            return this;
        }

        public OdooClientOptionsBuilder UseCredentials(string username, string password)
        {
            _options.Username = username;
            _options.Password = password;
            return this;
        }

        internal OdooClientOptions Build() => _options;
    }
}
