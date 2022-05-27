<<<<<<< HEAD
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledMetrics : IMetrics
    {
        void IMetrics.SendGaugeMetric(string name, double value, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }

        void IMetrics.SendHistogramMetric(string name, double time, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }

        void IMetrics.SendSumMetric(string name, double value, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }
    }
}
=======
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledMetrics : IMetrics
    {
        void IMetrics.SendGaugeMetric(string name, double value, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }

        void IMetrics.SendHistogramMetric(string name, double time, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }

        void IMetrics.SendSumMetric(string name, double value, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
