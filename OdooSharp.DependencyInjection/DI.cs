using Microsoft.Extensions.DependencyInjection;
using OdooSharp.Client;
using OdooSharp.Configuration;
using System;

namespace OdooSharp.DependencyInjection
{
    public static class DI
    {
        public static void AddOdooClient(this IServiceCollection services, Action<OdooClientOptionsBuilder> builder)
        {
            var optionsBuilder = new OdooClientOptionsBuilder();
            builder?.Invoke(optionsBuilder);
            var options = optionsBuilder.Build();

            services.AddSingleton(new OdooClient(options));
        }
    }
}
