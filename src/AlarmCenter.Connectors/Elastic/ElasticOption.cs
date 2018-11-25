using System;
using Microsoft.Extensions.Configuration;

namespace AlarmCenter.Connectors.Elastic
{
    public class ElasticOption
    {
        public ElasticOption(IConfiguration config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            var section = config.GetSection("elastic");
            section.Bind(this);
        }

        public string Uri { get; set; }

        public string DefaultIndex { get; set; }
    }
}