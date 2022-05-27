<<<<<<< HEAD
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestRunner.TestLaunchers;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class TestListCacheData : ScriptableSingleton<TestListCacheData>, ITestListCacheData
    {
        [SerializeField]
        private List<TestPlatform> m_Platforms = new List<TestPlatform>();

        [SerializeField]
        private List<ITest> m_CachedData = new List<ITest>();

        public List<TestPlatform> platforms
        {
            get { return m_Platforms; }
        }

        public List<ITest> cachedData
        {
            get { return m_CachedData; }
        }
    }
}
=======
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestRunner.TestLaunchers;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class TestListCacheData : ScriptableSingleton<TestListCacheData>, ITestListCacheData
    {
        [SerializeField]
        private List<TestPlatform> m_Platforms = new List<TestPlatform>();

        [SerializeField]
        private List<ITest> m_CachedData = new List<ITest>();

        public List<TestPlatform> platforms
        {
            get { return m_Platforms; }
        }

        public List<ITest> cachedData
        {
            get { return m_CachedData; }
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
