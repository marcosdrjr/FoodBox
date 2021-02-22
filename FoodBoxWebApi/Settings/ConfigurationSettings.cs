using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBoxWebApi.Settings
{
    public class ConfigurationSettings
    {
        public string ConnectionStrings { get; set; }

        public ConfigurationSettings()
        {
        }

        public ConfigurationSettings(IConfiguration config)
        {
            ConnectionStrings = config.GetValue<string>("ConnectionStrings:cnnLocal"); ;
        }
    }
}
