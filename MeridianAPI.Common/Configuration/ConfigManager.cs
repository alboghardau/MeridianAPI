using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeridianAPI.Common.Configuration
{
    public class ConfigManager
    {
        JObject configuration;

        #region Singleton
        private static readonly ConfigManager instance = new ConfigManager();
        static ConfigManager() { }

        private ConfigManager()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "config.json");
            configuration = JObject.Parse(File.ReadAllText(path));
        }

        public static ConfigManager Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion
    }
}
