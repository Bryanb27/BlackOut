<<<<<<< HEAD
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledDiagnostics : IDiagnostics
    {
        void IDiagnostics.SendDiagnostic(string name, string message, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }
    }
}
=======
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledDiagnostics : IDiagnostics
    {
        void IDiagnostics.SendDiagnostic(string name, string message, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
