<<<<<<< HEAD
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Unity.Services.Core.Configuration
{
    [Serializable]
    struct SerializableProjectConfiguration
    {
        public static SerializableProjectConfiguration Empty
            => new SerializableProjectConfiguration
        {
            Keys = Array.Empty<string>(),
            Values = Array.Empty<ConfigurationEntry>(),
        };

        [JsonRequired]
        [SerializeField]
        internal string[] Keys;

        [JsonRequired]
        [SerializeField]
        internal ConfigurationEntry[] Values;

        public SerializableProjectConfiguration(IDictionary<string, ConfigurationEntry> configValues)
        {
            Keys = new string[configValues.Count];
            Values = new ConfigurationEntry[configValues.Count];

            var i = 0;
            foreach (var configValue in configValues)
            {
                Keys[i] = configValue.Key;
                Values[i] = configValue.Value;
                ++i;
            }
        }
    }
}
=======
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Unity.Services.Core.Configuration
{
    [Serializable]
    struct SerializableProjectConfiguration
    {
        public static SerializableProjectConfiguration Empty
            => new SerializableProjectConfiguration
        {
            Keys = Array.Empty<string>(),
            Values = Array.Empty<ConfigurationEntry>(),
        };

        [JsonRequired]
        [SerializeField]
        internal string[] Keys;

        [JsonRequired]
        [SerializeField]
        internal ConfigurationEntry[] Values;

        public SerializableProjectConfiguration(IDictionary<string, ConfigurationEntry> configValues)
        {
            Keys = new string[configValues.Count];
            Values = new ConfigurationEntry[configValues.Count];

            var i = 0;
            foreach (var configValue in configValues)
            {
                Keys[i] = configValue.Key;
                Values[i] = configValue.Value;
                ++i;
            }
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
