<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools
{
    /// <summary>
    /// A flag indicating the targeted test platforms.
    /// </summary>
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        /// <summary>
        /// Both platforms.
        /// </summary>
        All = 0xFF,
        /// <summary>
        /// The EditMode test platform.
        /// </summary>
        EditMode = 1 << 1,
        /// <summary>
        /// The PlayMode test platform.
        /// </summary>
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
=======
using System;

namespace UnityEngine.TestTools
{
    /// <summary>
    /// A flag indicating the targeted test platforms.
    /// </summary>
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        /// <summary>
        /// Both platforms.
        /// </summary>
        All = 0xFF,
        /// <summary>
        /// The EditMode test platform.
        /// </summary>
        EditMode = 1 << 1,
        /// <summary>
        /// The PlayMode test platform.
        /// </summary>
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
