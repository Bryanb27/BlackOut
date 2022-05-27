<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ITestRunnerApi
    {
        string Execute(ExecutionSettings executionSettings);
        void RegisterCallbacks<T>(T testCallbacks, int priority = 0) where T : ICallbacks;
        void UnregisterCallbacks<T>(T testCallbacks) where T : ICallbacks;
        void RetrieveTestList(TestMode testMode, Action<ITestAdaptor> callback);
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ITestRunnerApi
    {
        string Execute(ExecutionSettings executionSettings);
        void RegisterCallbacks<T>(T testCallbacks, int priority = 0) where T : ICallbacks;
        void UnregisterCallbacks<T>(T testCallbacks) where T : ICallbacks;
        void RetrieveTestList(TestMode testMode, Action<ITestAdaptor> callback);
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
