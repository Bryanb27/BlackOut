<<<<<<< HEAD
using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
    class Diagnostics : IDiagnostics
    {
        internal DiagnosticsHandler Handler { get; }

        internal IDictionary<string, string> PackageTags { get; }

        public Diagnostics(DiagnosticsHandler handler, IDictionary<string, string> packageTags)
        {
            Handler = handler;
            PackageTags = packageTags;
        }

        public void SendDiagnostic(string name, string message, IDictionary<string, string> tags = null)
        {
            var diagnostic = new Diagnostic
            {
                Content = tags is null
                    ? new Dictionary<string, string>(PackageTags)
                    : new Dictionary<string, string>(tags)
                        .MergeAllowOverride(PackageTags),
            };

            diagnostic.Content.Add(TagKeys.DiagnosticName, name);
            diagnostic.Content.Add(TagKeys.DiagnosticMessage, message);

            Handler.Register(diagnostic);
        }
    }
}
=======
using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
    class Diagnostics : IDiagnostics
    {
        internal DiagnosticsHandler Handler { get; }

        internal IDictionary<string, string> PackageTags { get; }

        public Diagnostics(DiagnosticsHandler handler, IDictionary<string, string> packageTags)
        {
            Handler = handler;
            PackageTags = packageTags;
        }

        public void SendDiagnostic(string name, string message, IDictionary<string, string> tags = null)
        {
            var diagnostic = new Diagnostic
            {
                Content = tags is null
                    ? new Dictionary<string, string>(PackageTags)
                    : new Dictionary<string, string>(tags)
                        .MergeAllowOverride(PackageTags),
            };

            diagnostic.Content.Add(TagKeys.DiagnosticName, name);
            diagnostic.Content.Add(TagKeys.DiagnosticMessage, message);

            Handler.Register(diagnostic);
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
