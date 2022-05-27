<<<<<<< HEAD
using System.Collections.Generic;
using System.Globalization;
using Unity.Services.Core.Configuration.Internal;

namespace Unity.Services.Core.Configuration
{
    class ProjectConfiguration : IProjectConfiguration
    {
        readonly IDictionary<string, ConfigurationEntry> m_ConfigValues;

        public ProjectConfiguration(IDictionary<string, ConfigurationEntry> configValues)
        {
            m_ConfigValues = configValues;
        }

        public bool GetBool(string key, bool defaultValue = default)
        {
            var stringConfig = GetString(key);
            if (bool.TryParse(stringConfig, out var parsedValue))
            {
                return parsedValue;
            }

            return defaultValue;
        }

        public int GetInt(string key, int defaultValue = default)
        {
            var stringConfig = GetString(key);
            if (int.TryParse(stringConfig, out var parsedValue))
            {
                return parsedValue;
            }

            return defaultValue;
        }

        public float GetFloat(string key, float defaultValue = default)
        {
            var stringConfig = GetString(key);
            if (float.TryParse(stringConfig, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsedValue))
            {
                return parsedValue;
            }

            return defaultValue;
        }

        public string GetString(string key, string defaultValue = default)
        {
            if (m_ConfigValues.TryGetValue(key, out var configValue))
            {
                return configValue.Value;
            }

            return defaultValue;
        }
    }
}
=======
using System.Collections.Generic;
using System.Globalization;
using Unity.Services.Core.Configuration.Internal;

namespace Unity.Services.Core.Configuration
{
    class ProjectConfiguration : IProjectConfiguration
    {
        readonly IDictionary<string, ConfigurationEntry> m_ConfigValues;

        public ProjectConfiguration(IDictionary<string, ConfigurationEntry> configValues)
        {
            m_ConfigValues = configValues;
        }

        public bool GetBool(string key, bool defaultValue = default)
        {
            var stringConfig = GetString(key);
            if (bool.TryParse(stringConfig, out var parsedValue))
            {
                return parsedValue;
            }

            return defaultValue;
        }

        public int GetInt(string key, int defaultValue = default)
        {
            var stringConfig = GetString(key);
            if (int.TryParse(stringConfig, out var parsedValue))
            {
                return parsedValue;
            }

            return defaultValue;
        }

        public float GetFloat(string key, float defaultValue = default)
        {
            var stringConfig = GetString(key);
            if (float.TryParse(stringConfig, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsedValue))
            {
                return parsedValue;
            }

            return defaultValue;
        }

        public string GetString(string key, string defaultValue = default)
        {
            if (m_ConfigValues.TryGetValue(key, out var configValue))
            {
                return configValue.Value;
            }

            return defaultValue;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
