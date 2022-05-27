<<<<<<< HEAD
using System;
using System.Linq;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    [InitializeOnLoad]
    internal static class UnityTestProtocolStarter
    {
        static UnityTestProtocolStarter()
        {
            var commandLineArgs = Environment.GetCommandLineArgs();
            if (commandLineArgs.Contains("-automated") && commandLineArgs.Contains("-runTests")) // wanna have it only for utr run
            {
                var api = ScriptableObject.CreateInstance<TestRunnerApi>();
                var listener = ScriptableObject.CreateInstance<UnityTestProtocolListener>();
                api.RegisterCallbacks(listener);
            }
        }
    }
}
=======
using System;
using System.Linq;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    [InitializeOnLoad]
    internal static class UnityTestProtocolStarter
    {
        static UnityTestProtocolStarter()
        {
            var commandLineArgs = Environment.GetCommandLineArgs();
            if (commandLineArgs.Contains("-automated") && commandLineArgs.Contains("-runTests")) // wanna have it only for utr run
            {
                var api = ScriptableObject.CreateInstance<TestRunnerApi>();
                var listener = ScriptableObject.CreateInstance<UnityTestProtocolListener>();
                api.RegisterCallbacks(listener);
            }
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
