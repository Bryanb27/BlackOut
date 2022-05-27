<<<<<<< HEAD
using System;
using System.Collections.Generic;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
    static class FactoryUtils
    {
        internal const string PackageVersionKeyFormat = "{0}.version";

        public static IDictionary<string, string> CreatePackageTags(
            IProjectConfiguration projectConfig, string packageName)
        {
            var packageVersion = projectConfig.GetString(string.Format(PackageVersionKeyFormat, packageName), String.Empty);
            if (string.IsNullOrEmpty(packageVersion))
            {
                CoreLogger.LogVerbose($"No package version found for the package \"{packageName}\"");
            }

            return new Dictionary<string, string>
            {
                [TagKeys.PackageName] = packageName,
                [TagKeys.PackageVersion] = packageVersion,
            };
        }
    }
}
=======
using System;
using System.Collections.Generic;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
    static class FactoryUtils
    {
        internal const string PackageVersionKeyFormat = "{0}.version";

        public static IDictionary<string, string> CreatePackageTags(
            IProjectConfiguration projectConfig, string packageName)
        {
            var packageVersion = projectConfig.GetString(string.Format(PackageVersionKeyFormat, packageName), String.Empty);
            if (string.IsNullOrEmpty(packageVersion))
            {
                CoreLogger.LogVerbose($"No package version found for the package \"{packageName}\"");
            }

            return new Dictionary<string, string>
            {
                [TagKeys.PackageName] = packageName,
                [TagKeys.PackageVersion] = packageVersion,
            };
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
