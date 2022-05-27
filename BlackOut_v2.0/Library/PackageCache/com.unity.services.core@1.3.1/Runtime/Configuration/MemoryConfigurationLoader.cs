<<<<<<< HEAD
using System.Threading.Tasks;

namespace Unity.Services.Core.Configuration
{
    class MemoryConfigurationLoader : IConfigurationLoader
    {
        public SerializableProjectConfiguration Config { get; set; }

        Task<SerializableProjectConfiguration> IConfigurationLoader.GetConfigAsync()
        {
            var completionSource = new TaskCompletionSource<SerializableProjectConfiguration>();
            completionSource.SetResult(Config);
            return completionSource.Task;
        }
    }
}
=======
using System.Threading.Tasks;

namespace Unity.Services.Core.Configuration
{
    class MemoryConfigurationLoader : IConfigurationLoader
    {
        public SerializableProjectConfiguration Config { get; set; }

        Task<SerializableProjectConfiguration> IConfigurationLoader.GetConfigAsync()
        {
            var completionSource = new TaskCompletionSource<SerializableProjectConfiguration>();
            completionSource.SetResult(Config);
            return completionSource.Task;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
