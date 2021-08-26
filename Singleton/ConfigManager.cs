using System.Collections.Generic;

namespace Singleton
{
    public class ConfigManager
    {
        private Dictionary<string, object> settings = new Dictionary<string, object>();

        public void Set(string key, object value)
        {
            settings.Add(key, value);
        }

        public object Get(string key)
        {
            return settings[key];
        }
    }
}
