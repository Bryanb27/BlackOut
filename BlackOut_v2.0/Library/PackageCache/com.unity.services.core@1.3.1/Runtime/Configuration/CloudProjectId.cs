<<<<<<< HEAD
using UnityEngine;
using Unity.Services.Core.Configuration.Internal;

namespace Unity.Services.Core.Configuration
{
    class CloudProjectId : ICloudProjectId
    {
        public string GetCloudProjectId()
        {
            return Application.cloudProjectId;
        }
    }
}
=======
using UnityEngine;
using Unity.Services.Core.Configuration.Internal;

namespace Unity.Services.Core.Configuration
{
    class CloudProjectId : ICloudProjectId
    {
        public string GetCloudProjectId()
        {
            return Application.cloudProjectId;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
