<<<<<<< HEAD
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledMetricsFactory : IMetricsFactory
    {
        IReadOnlyDictionary<string, string> IMetricsFactory.CommonTags { get; }
            = new Dictionary<string, string>();

        IMetrics IMetricsFactory.Create(string packageName) => new DisabledMetrics();
    }
}
=======
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledMetricsFactory : IMetricsFactory
    {
        IReadOnlyDictionary<string, string> IMetricsFactory.CommonTags { get; }
            = new Dictionary<string, string>();

        IMetrics IMetricsFactory.Create(string packageName) => new DisabledMetrics();
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
