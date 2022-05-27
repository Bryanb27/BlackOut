<<<<<<< HEAD
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    interface ITelemetryPayload
    {
        Dictionary<string, string> CommonTags { get; }

        int Count { get; }

        void Add(ITelemetryEvent telemetryEvent);
    }
}
=======
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    interface ITelemetryPayload
    {
        Dictionary<string, string> CommonTags { get; }

        int Count { get; }

        void Add(ITelemetryEvent telemetryEvent);
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
