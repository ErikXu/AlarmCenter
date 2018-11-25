using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace AlarmCenter.Connectors.Elastic
{
    public static class ElasticServiceCollectionExtensions
    {
        public static IServiceCollection AddElasticClient(this IServiceCollection services, IConfiguration config)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            services.AddOptions();

            var elasticOption = new ElasticOption(config);

            var settings = new ConnectionSettings(new Uri(elasticOption.Uri)).DefaultIndex(elasticOption.DefaultIndex);

            services.Add(ServiceDescriptor.Singleton(new ElasticClient(settings)));
            return services;
        }
    }
}