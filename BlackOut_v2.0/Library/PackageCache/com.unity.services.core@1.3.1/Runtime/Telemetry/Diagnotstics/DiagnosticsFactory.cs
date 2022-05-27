<<<<<<< HEAD
using System;
using System.Collections.Generic;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DiagnosticsFactory : IDiagnosticsFactory
    {
        readonly IProjectConfiguration m_ProjectConfig;

        public IReadOnlyDictionary<string, string> CommonTags { get; }

        internal DiagnosticsHandler Handler { get; }

        public DiagnosticsFactory(DiagnosticsHandler handler, IProjectConfiguration projectConfig)
        {
            Handler = handler;
            m_ProjectConfig = projectConfig;

            CommonTags = new Dictionary<string, string>(handler.Cache.Payload.CommonTags)
                .MergeAllowOverride(handler.Cache.Payload.DiagnosticsCommonTags);
        }

        public IDiagnostics Create(string packageName)
        {
            if (string.IsNullOrEmpty(packageName))
                throw new ArgumentNullException(nameof(packageName));

            var packageTags = FactoryUtils.CreatePackageTags(m_ProjectConfig, packageName);
            var diagnostics = new Diagnostics(Handler, packageTags);

            return diagnostics;
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
    class DiagnosticsFactory : IDiagnosticsFactory
    {
        readonly IProjectConfiguration m_ProjectConfig;

        public IReadOnlyDictionary<string, string> CommonTags { get; }

        internal DiagnosticsHandler Handler { get; }

        public DiagnosticsFactory(DiagnosticsHandler handler, IProjectConfiguration projectConfig)
        {
            Handler = handler;
            m_ProjectConfig = projectConfig;

            CommonTags = new Dictionary<string, string>(handler.Cache.Payload.CommonTags)
                .MergeAllowOverride(handler.Cache.Payload.DiagnosticsCommonTags);
        }

        public IDiagnostics Create(string packageName)
        {
            if (string.IsNullOrEmpty(packageName))
                throw new ArgumentNullException(nameof(packageName));

            var packageTags = FactoryUtils.CreatePackageTags(m_ProjectConfig, packageName);
            var diagnostics = new Diagnostics(Handler, packageTags);

            return diagnostics;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
