using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Helpers
{
    public static class ConfigurationHelper
    {
        private static IConfiguration _configuration;

        static ConfigurationHelper()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();
        }

        public static string GetConnectionString(string name)
        {
            return _configuration.GetConnectionString(name);
        }
    }
}
