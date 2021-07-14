using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeridianAPI.Common.Configuration
{
    class ConfigManager
    {
        private static readonly ConfigManager instance = new ConfigManager();

        static ConfigManager() { }

        private ConfigManager()
        {

        }
    }
}
