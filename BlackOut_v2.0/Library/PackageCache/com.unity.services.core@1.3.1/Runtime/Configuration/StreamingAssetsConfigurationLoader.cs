<<<<<<< HEAD
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Unity.Services.Core.Configuration
{
    class StreamingAssetsConfigurationLoader : IConfigurationLoader
    {
        public async Task<SerializableProjectConfiguration> GetConfigAsync()
        {
            var jsonConfig = await StreamingAssetsUtils.GetFileTextFromStreamingAssetsAsync(
                ConfigurationUtils.ConfigFileName);
            var config = JsonConvert.DeserializeObject<SerializableProjectConfiguration>(jsonConfig);
            return config;
        }
    }
}
=======
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Unity.Services.Core.Configuration
{
    class StreamingAssetsConfigurationLoader : IConfigurationLoader
    {
        public async Task<SerializableProjectConfiguration> GetConfigAsync()
        {
            var jsonConfig = await StreamingAssetsUtils.GetFileTextFromStreamingAssetsAsync(
                ConfigurationUtils.ConfigFileName);
            var config = JsonConvert.DeserializeObject<SerializableProjectConfiguration>(jsonConfig);
            return config;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
