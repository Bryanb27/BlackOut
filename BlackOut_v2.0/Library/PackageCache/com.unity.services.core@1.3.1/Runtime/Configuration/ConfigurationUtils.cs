<<<<<<< HEAD
using System.IO;
using UnityEngine;

namespace Unity.Services.Core.Configuration
{
    static class ConfigurationUtils
    {
        public const string StreamingAssetsFolder = "StreamingAssets";
        public const string StreamingAssetsPath = "Assets/" + StreamingAssetsFolder;
        public const string ConfigFileName = "UnityServicesProjectConfiguration.json";

        public static string RuntimeConfigFullPath { get; }
            = Path.Combine(Application.streamingAssetsPath, ConfigFileName);

        public static IConfigurationLoader ConfigurationLoader { get; internal set; }
            = new StreamingAssetsConfigurationLoader();
    }
}
=======
using System.IO;
using UnityEngine;

namespace Unity.Services.Core.Configuration
{
    static class ConfigurationUtils
    {
        public const string StreamingAssetsFolder = "StreamingAssets";
        public const string StreamingAssetsPath = "Assets/" + StreamingAssetsFolder;
        public const string ConfigFileName = "UnityServicesProjectConfiguration.json";

        public static string RuntimeConfigFullPath { get; }
            = Path.Combine(Application.streamingAssetsPath, ConfigFileName);

        public static IConfigurationLoader ConfigurationLoader { get; internal set; }
            = new StreamingAssetsConfigurationLoader();
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
