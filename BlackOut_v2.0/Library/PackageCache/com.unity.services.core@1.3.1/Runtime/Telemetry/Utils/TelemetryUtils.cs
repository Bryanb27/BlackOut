<<<<<<< HEAD
using System.Collections.Generic;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Scheduler.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
    static class TelemetryUtils
    {
        internal const string TelemetryDisabledKey = "com.unity.services.core.telemetry-disabled";

        public static IMetricsFactory CreateMetricsFactory(
            IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId,
            IEnvironments environments)
        {
            if (IsTelemetryDisabled(projectConfiguration))
            {
                return new DisabledMetricsFactory();
            }

            var config = CreateTelemetryConfig(projectConfiguration);
            var cache = new CachedPayload<MetricsPayload>
            {
                Payload = new MetricsPayload
                {
                    Metrics = new List<Metric>(),
                    CommonTags = new Dictionary<string, string>(),
                    MetricsCommonTags = new Dictionary<string, string>(),
                },
            };
            var cachePersister = new FileCachePersister<MetricsPayload>("UnityServicesCachedMetrics");
            var retryPolicy = new ExponentialBackOffRetryPolicy();
            var requestSender = new UnityWebRequestSender();
            var metricsSender = new TelemetrySender(
                config.TargetUrl, config.ServicePath, scheduler, retryPolicy, requestSender);
            var handler = new MetricsHandler(config, cache, scheduler, cachePersister, metricsSender);
            handler.Initialize(cloudProjectId, environments);

            return new MetricsFactory(handler, projectConfiguration);
        }

        //TODO: Reuse components from MetricsFactory (or vice versa)
        public static IDiagnosticsFactory CreateDiagnosticsFactory(
            IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId,
            IEnvironments environments)
        {
            if (IsTelemetryDisabled(projectConfiguration))
            {
                return new DisabledDiagnosticsFactory();
            }

            var config = CreateTelemetryConfig(projectConfiguration);
            var cache = new CachedPayload<DiagnosticsPayload>
            {
                Payload = new DiagnosticsPayload
                {
                    Diagnostics = new List<Diagnostic>(),
                    CommonTags = new Dictionary<string, string>(),
                    DiagnosticsCommonTags = new Dictionary<string, string>(),
                },
            };
            var cachePersister = new FileCachePersister<DiagnosticsPayload>("UnityServicesCachedDiagnostics");
            var retryPolicy = new ExponentialBackOffRetryPolicy();
            var requestSender = new UnityWebRequestSender();
            var metricsSender = new TelemetrySender(
                config.TargetUrl, config.ServicePath, scheduler, retryPolicy, requestSender);
            var handler = new DiagnosticsHandler(
                config, cache, scheduler, cachePersister, metricsSender);
            handler.Initialize(cloudProjectId, environments);

            return new DiagnosticsFactory(handler, projectConfiguration);
        }

        static bool IsTelemetryDisabled(IProjectConfiguration projectConfiguration)
            => projectConfiguration.GetBool(TelemetryDisabledKey);

        internal static TelemetryConfig CreateTelemetryConfig(IProjectConfiguration projectConfiguration)
        {
            const string defaultTargetUrl = "https://operate-sdk-telemetry.unity3d.com";
            const string defaultServicePath = "v1/record";
            const int defaultPayloadExpirationSeconds = 3600;
            const int defaultPayloadSendingMaxIntervalSeconds = 600;
            const int defaultSafetyPersistenceIntervalSeconds = 300;
            const int defaultMaxMetricCountPerPayload = 2000;

            var config = new TelemetryConfig
            {
                TargetUrl = projectConfiguration.GetString(TelemetryConfigKeys.TargetUrl, defaultTargetUrl),
                ServicePath = projectConfiguration.GetString(TelemetryConfigKeys.ServicePath, defaultServicePath),
                PayloadExpirationSeconds = projectConfiguration.GetInt(TelemetryConfigKeys.PayloadExpirationSeconds, defaultPayloadExpirationSeconds),
                PayloadSendingMaxIntervalSeconds = projectConfiguration.GetInt(TelemetryConfigKeys.PayloadSendingMaxIntervalSeconds, defaultPayloadSendingMaxIntervalSeconds),
                SafetyPersistenceIntervalSeconds = projectConfiguration.GetInt(TelemetryConfigKeys.SafetyPersistenceIntervalSeconds, defaultSafetyPersistenceIntervalSeconds),
                MaxMetricCountPerPayload = projectConfiguration.GetInt(TelemetryConfigKeys.MaxMetricCountPerPayload, defaultMaxMetricCountPerPayload),
            };
            return config;
        }
    }
}
=======
using System.Collections.Generic;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Scheduler.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
    static class TelemetryUtils
    {
        internal const string TelemetryDisabledKey = "com.unity.services.core.telemetry-disabled";

        public static IMetricsFactory CreateMetricsFactory(
            IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId,
            IEnvironments environments)
        {
            if (IsTelemetryDisabled(projectConfiguration))
            {
                return new DisabledMetricsFactory();
            }

            var config = CreateTelemetryConfig(projectConfiguration);
            var cache = new CachedPayload<MetricsPayload>
            {
                Payload = new MetricsPayload
                {
                    Metrics = new List<Metric>(),
                    CommonTags = new Dictionary<string, string>(),
                    MetricsCommonTags = new Dictionary<string, string>(),
                },
            };
            var cachePersister = new FileCachePersister<MetricsPayload>("UnityServicesCachedMetrics");
            var retryPolicy = new ExponentialBackOffRetryPolicy();
            var requestSender = new UnityWebRequestSender();
            var metricsSender = new TelemetrySender(
                config.TargetUrl, config.ServicePath, scheduler, retryPolicy, requestSender);
            var handler = new MetricsHandler(config, cache, scheduler, cachePersister, metricsSender);
            handler.Initialize(cloudProjectId, environments);

            return new MetricsFactory(handler, projectConfiguration);
        }

        //TODO: Reuse components from MetricsFactory (or vice versa)
        public static IDiagnosticsFactory CreateDiagnosticsFactory(
            IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId,
            IEnvironments environments)
        {
            if (IsTelemetryDisabled(projectConfiguration))
            {
                return new DisabledDiagnosticsFactory();
            }

            var config = CreateTelemetryConfig(projectConfiguration);
            var cache = new CachedPayload<DiagnosticsPayload>
            {
                Payload = new DiagnosticsPayload
                {
                    Diagnostics = new List<Diagnostic>(),
                    CommonTags = new Dictionary<string, string>(),
                    DiagnosticsCommonTags = new Dictionary<string, string>(),
                },
            };
            var cachePersister = new FileCachePersister<DiagnosticsPayload>("UnityServicesCachedDiagnostics");
            var retryPolicy = new ExponentialBackOffRetryPolicy();
            var requestSender = new UnityWebRequestSender();
            var metricsSender = new TelemetrySender(
                config.TargetUrl, config.ServicePath, scheduler, retryPolicy, requestSender);
            var handler = new DiagnosticsHandler(
                config, cache, scheduler, cachePersister, metricsSender);
            handler.Initialize(cloudProjectId, environments);

            return new DiagnosticsFactory(handler, projectConfiguration);
        }

        static bool IsTelemetryDisabled(IProjectConfiguration projectConfiguration)
            => projectConfiguration.GetBool(TelemetryDisabledKey);

        internal static TelemetryConfig CreateTelemetryConfig(IProjectConfiguration projectConfiguration)
        {
            const string defaultTargetUrl = "https://operate-sdk-telemetry.unity3d.com";
            const string defaultServicePath = "v1/record";
            const int defaultPayloadExpirationSeconds = 3600;
            const int defaultPayloadSendingMaxIntervalSeconds = 600;
            const int defaultSafetyPersistenceIntervalSeconds = 300;
            const int defaultMaxMetricCountPerPayload = 2000;

            var config = new TelemetryConfig
            {
                TargetUrl = projectConfiguration.GetString(TelemetryConfigKeys.TargetUrl, defaultTargetUrl),
                ServicePath = projectConfiguration.GetString(TelemetryConfigKeys.ServicePath, defaultServicePath),
                PayloadExpirationSeconds = projectConfiguration.GetInt(TelemetryConfigKeys.PayloadExpirationSeconds, defaultPayloadExpirationSeconds),
                PayloadSendingMaxIntervalSeconds = projectConfiguration.GetInt(TelemetryConfigKeys.PayloadSendingMaxIntervalSeconds, defaultPayloadSendingMaxIntervalSeconds),
                SafetyPersistenceIntervalSeconds = projectConfiguration.GetInt(TelemetryConfigKeys.SafetyPersistenceIntervalSeconds, defaultSafetyPersistenceIntervalSeconds),
                MaxMetricCountPerPayload = projectConfiguration.GetInt(TelemetryConfigKeys.MaxMetricCountPerPayload, defaultMaxMetricCountPerPayload),
            };
            return config;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
