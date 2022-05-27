<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.Api.Analytics
{
    internal class AnalyticsTestCallback : ICallbacks
    {
        private Action<ITestResultAdaptor> _runFinishedCallback;

        public AnalyticsTestCallback(Action<ITestResultAdaptor> runFinishedCallback)
        {
            _runFinishedCallback = runFinishedCallback;
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
        }

        public void RunFinished(ITestResultAdaptor result)
        {
            _runFinishedCallback(result);
        }

        public void TestStarted(ITestAdaptor test)
        {
        }

        public void TestFinished(ITestResultAdaptor result)
        {
        }
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.Api.Analytics
{
    internal class AnalyticsTestCallback : ICallbacks
    {
        private Action<ITestResultAdaptor> _runFinishedCallback;

        public AnalyticsTestCallback(Action<ITestResultAdaptor> runFinishedCallback)
        {
            _runFinishedCallback = runFinishedCallback;
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
        }

        public void RunFinished(ITestResultAdaptor result)
        {
            _runFinishedCallback(result);
        }

        public void TestStarted(ITestAdaptor test)
        {
        }

        public void TestFinished(ITestResultAdaptor result)
        {
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
