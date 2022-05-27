<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class SetupException : Exception
    {
        public ExceptionType Type { get; }
        public object[] Details { get; }

        public SetupException(ExceptionType type, params object[] details)
        {
            Type = type;
            Details = details;
        }

        public enum ExceptionType
        {
            ScriptCompilationFailed,
            PlatformNotFound,
            TestSettingsFileNotFound,
        }
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class SetupException : Exception
    {
        public ExceptionType Type { get; }
        public object[] Details { get; }

        public SetupException(ExceptionType type, params object[] details)
        {
            Type = type;
            Details = details;
        }

        public enum ExceptionType
        {
            ScriptCompilationFailed,
            PlatformNotFound,
            TestSettingsFileNotFound,
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
