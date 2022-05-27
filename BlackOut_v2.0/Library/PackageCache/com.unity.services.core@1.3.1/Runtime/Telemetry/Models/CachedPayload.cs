<<<<<<< HEAD
using System;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    class CachedPayload<TPayload>
        where TPayload : ITelemetryPayload
    {
        /// <summary>
        /// Time, in ticks, the first event of this payload was recorded.
        /// It uses <see cref="DateTime.UtcNow"/>.
        /// </summary>
        public long TimeOfOccurenceTicks;

        public TPayload Payload;
    }
}
=======
using System;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    class CachedPayload<TPayload>
        where TPayload : ITelemetryPayload
    {
        /// <summary>
        /// Time, in ticks, the first event of this payload was recorded.
        /// It uses <see cref="DateTime.UtcNow"/>.
        /// </summary>
        public long TimeOfOccurenceTicks;

        public TPayload Payload;
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
