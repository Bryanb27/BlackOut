<<<<<<< HEAD
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner
{
    internal class TestRunnerCallback : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(ITest testsToRun)
        {
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingPlayMode)
            {
                EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
                //We need to make sure we don't block NUnit thread in case we exit PlayMode earlier
                PlaymodeTestsController.TryCleanup();
            }
        }

        public void RunFinished(ITestResult testResults)
        {
            EditorApplication.isPlaying = false;
        }

        public void TestStarted(ITest testName)
        {
        }

        public void TestFinished(ITestResult test)
        {
        }
    }
}
=======
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner
{
    internal class TestRunnerCallback : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(ITest testsToRun)
        {
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingPlayMode)
            {
                EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
                //We need to make sure we don't block NUnit thread in case we exit PlayMode earlier
                PlaymodeTestsController.TryCleanup();
            }
        }

        public void RunFinished(ITestResult testResults)
        {
            EditorApplication.isPlaying = false;
        }

        public void TestStarted(ITest testName)
        {
        }

        public void TestFinished(ITestResult test)
        {
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
