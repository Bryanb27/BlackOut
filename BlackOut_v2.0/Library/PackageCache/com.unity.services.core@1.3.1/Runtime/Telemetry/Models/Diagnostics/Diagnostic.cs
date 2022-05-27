<<<<<<< HEAD
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    struct Diagnostic : ITelemetryEvent
    {
        [JsonProperty("content")]
        public IDictionary<string, string> Content;
    }
}
=======
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    struct Diagnostic : ITelemetryEvent
    {
        [JsonProperty("content")]
        public IDictionary<string, string> Content;
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
