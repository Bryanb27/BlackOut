<<<<<<< HEAD
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    class PlayerLauncherTestRunSettings : ITestRunSettings
    {
        public bool buildOnly { set; get; }

        public string buildOnlyLocationPath { set; get; }

        public void Dispose()
        {
        }

        void ITestRunSettings.Apply()
        {
        }
    }
=======
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    class PlayerLauncherTestRunSettings : ITestRunSettings
    {
        public bool buildOnly { set; get; }

        public string buildOnlyLocationPath { set; get; }

        public void Dispose()
        {
        }

        void ITestRunSettings.Apply()
        {
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}