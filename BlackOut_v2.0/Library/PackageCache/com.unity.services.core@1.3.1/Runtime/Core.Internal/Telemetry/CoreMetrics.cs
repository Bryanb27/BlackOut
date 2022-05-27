<<<<<<< HEAD
using Unity.Services.Core.Telemetry.Internal;

namespace Unity.Services.Core.Internal
{
    /// <summary>
    /// This object sends all metric events for the Services Core package.
    /// </summary>
    class CoreMetrics
    {
        internal const string CorePackageInitTimeMetricName = "package_init_time";

        internal const string AllPackagesInitSuccessMetricName = "all_packages_init_success";

        internal const string AllPackagesInitTimeMetricName = "all_packages_init_time";

        public static CoreMetrics Instance { get; internal set; }

        internal IMetrics Metrics { get; set; }

        public void SendAllPackagesInitSuccessMetric()
        {
            Metrics.SendSumMetric(AllPackagesInitSuccessMetricName);
        }

        public void SendAllPackagesInitTimeMetric(double initTimeSeconds)
        {
            Metrics.SendHistogramMetric(AllPackagesInitTimeMetricName, initTimeSeconds);
        }

        public void SendCorePackageInitTimeMetric(double initTimeSeconds)
        {
            Metrics.SendHistogramMetric(CorePackageInitTimeMetricName, initTimeSeconds);
        }
    }
}
=======
using Unity.Services.Core.Telemetry.Internal;

namespace Unity.Services.Core.Internal
{
    /// <summary>
    /// This object sends all metric events for the Services Core package.
    /// </summary>
    class CoreMetrics
    {
        internal const string CorePackageInitTimeMetricName = "package_init_time";

        internal const string AllPackagesInitSuccessMetricName = "all_packages_init_success";

        internal const string AllPackagesInitTimeMetricName = "all_packages_init_time";

        public static CoreMetrics Instance { get; internal set; }

        internal IMetrics Metrics { get; set; }

        public void SendAllPackagesInitSuccessMetric()
        {
            Metrics.SendSumMetric(AllPackagesInitSuccessMetricName);
        }

        public void SendAllPackagesInitTimeMetric(double initTimeSeconds)
        {
            Metrics.SendHistogramMetric(AllPackagesInitTimeMetricName, initTimeSeconds);
        }

        public void SendCorePackageInitTimeMetric(double initTimeSeconds)
        {
            Metrics.SendHistogramMetric(CorePackageInitTimeMetricName, initTimeSeconds);
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
