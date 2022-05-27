<<<<<<< HEAD
using System.Runtime.Serialization;

namespace Unity.Services.Core.Telemetry.Internal
{
    enum MetricType
    {
        [EnumMember(Value = "GAUGE")]
        Gauge = 0,
        [EnumMember(Value = "SUM")]
        Sum = 1,
        [EnumMember(Value = "HISTOGRAM")]
        Histogram = 2,
    }
}
=======
using System.Runtime.Serialization;

namespace Unity.Services.Core.Telemetry.Internal
{
    enum MetricType
    {
        [EnumMember(Value = "GAUGE")]
        Gauge = 0,
        [EnumMember(Value = "SUM")]
        Sum = 1,
        [EnumMember(Value = "HISTOGRAM")]
        Histogram = 2,
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
