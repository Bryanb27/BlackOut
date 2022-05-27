<<<<<<< HEAD
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledDiagnosticsFactory : IDiagnosticsFactory
    {
        IReadOnlyDictionary<string, string> IDiagnosticsFactory.CommonTags { get; }
            = new Dictionary<string, string>();

        IDiagnostics IDiagnosticsFactory.Create(string packageName) => new DisabledDiagnostics();
    }
}
=======
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledDiagnosticsFactory : IDiagnosticsFactory
    {
        IReadOnlyDictionary<string, string> IDiagnosticsFactory.CommonTags { get; }
            = new Dictionary<string, string>();

        IDiagnostics IDiagnosticsFactory.Create(string packageName) => new DisabledDiagnostics();
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
