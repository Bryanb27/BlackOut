<<<<<<< HEAD
using System;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    class TelemetryConfig
    {
        public string TargetUrl;

        public string ServicePath;

        public double PayloadExpirationSeconds;

        public double PayloadSendingMaxIntervalSeconds;

        public double SafetyPersistenceIntervalSeconds;

        public int MaxMetricCountPerPayload;
    }
}
=======
using System;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    class TelemetryConfig
    {
        public string TargetUrl;

        public string ServicePath;

        public double PayloadExpirationSeconds;

        public double PayloadSendingMaxIntervalSeconds;

        public double SafetyPersistenceIntervalSeconds;

        public int MaxMetricCountPerPayload;
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
