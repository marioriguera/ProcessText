using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProcessText.Core.Business;
using ProcessText.Core.Business.Factory;
using ProcessText.Core.Contracts;
using ProcessText.Core.Contracts.Factory;

namespace ProcessText.Core.Dependencies
{
    /// <summary>
    /// Provides extension methods to register core dependencies.
    /// </summary>
    public static class Register
    {
        /// <summary>
        /// Adds core dependencies to the specified host builder.
        /// </summary>
        /// <param name="hostBuilder">The IHostBuilder to configure.</param>
        /// <returns>The configured IHostBuilder.</returns>
        public static IHostBuilder AddCoreDependencies(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
            {
                services.AddScoped<IOrderOptionsService, OrderOptionsService>();
                services.AddScoped<IOrderFactory, OrderFactory>();
                services.AddScoped<ITextAnalyzer, TextAnalyzer>();
            });

            return hostBuilder;
        }
    }
}
