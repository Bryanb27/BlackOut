<<<<<<< HEAD
using System;
using UnityEditor.PackageManager;
using CanBeNull = JetBrains.Annotations.CanBeNullAttribute;

namespace Unity.Services.Core.Editor
{
    [Serializable]
    struct PackageConfig
    {
        public string Name;

        public string Version;

        public PackageConfig([CanBeNull] PackageInfo packageInfo)
        {
            Name = packageInfo?.name;
            Version = packageInfo?.version;
        }
    }
}
=======
using System;
using UnityEditor.PackageManager;
using CanBeNull = JetBrains.Annotations.CanBeNullAttribute;

namespace Unity.Services.Core.Editor
{
    [Serializable]
    struct PackageConfig
    {
        public string Name;

        public string Version;

        public PackageConfig([CanBeNull] PackageInfo packageInfo)
        {
            Name = packageInfo?.name;
            Version = packageInfo?.version;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
