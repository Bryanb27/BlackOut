<<<<<<< HEAD
using UnityEngine;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    [InitializeOnLoad]
    static class RerunCallbackInitializer
    {
        static RerunCallbackInitializer()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

            var rerunCallback = ScriptableObject.CreateInstance<RerunCallback>();
            testRunnerApi.RegisterCallbacks<RerunCallback>(rerunCallback);
        }
    }
}
=======
using UnityEngine;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    [InitializeOnLoad]
    static class RerunCallbackInitializer
    {
        static RerunCallbackInitializer()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

            var rerunCallback = ScriptableObject.CreateInstance<RerunCallback>();
            testRunnerApi.RegisterCallbacks<RerunCallback>(rerunCallback);
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
