using OdooSharp.Configuration;
using System.Threading.Tasks;

namespace OdooSharp.Client
{
    public class OdooClientInitializer
    {
        private readonly IOdooClient _client;
        private readonly Task _initTask;
        public OdooClientInitializer(OdooClientOptions options)
        {
            _client = new OdooClient(options);
            _initTask = _client.AuthenticateAsync();
        }

        public IOdooClient GetClient()
        {
            if (_client.Authenticated)
            {
                return _client;
            }

            while (!_initTask.IsCompleted)
            {
                Task.Delay(100).Wait();
            }

            return _client;
        }
    }
}
