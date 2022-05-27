<<<<<<< HEAD
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class RunSettings : ITestRunSettings
    {
        private ITestSettings m_TestSettings;
        public RunSettings(ITestSettings testSettings)
        {
            this.m_TestSettings = testSettings;
        }

        public void Apply()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.SetupProjectParameters();
            }
        }

        public void Dispose()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.Dispose();
            }
        }
    }
}
=======
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class RunSettings : ITestRunSettings
    {
        private ITestSettings m_TestSettings;
        public RunSettings(ITestSettings testSettings)
        {
            this.m_TestSettings = testSettings;
        }

        public void Apply()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.SetupProjectParameters();
            }
        }

        public void Dispose()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.Dispose();
            }
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
