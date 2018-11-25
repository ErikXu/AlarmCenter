using System;
using Microsoft.Extensions.Configuration;

namespace AlarmCenter.Connectors.Rabbit
{
    public class RabbitOption
    {
        public RabbitOption(IConfiguration config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            var section = config.GetSection("rabbit");
            section.Bind(this);
        }

        public string Uri { get; set; }
    }
}