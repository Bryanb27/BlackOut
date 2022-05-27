<<<<<<< HEAD
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class TestTaskBase
    {
        public bool SupportsResumingEnumerator;

        protected TestTaskBase(bool supportsResumingEnumerator = false)
        {
            SupportsResumingEnumerator = supportsResumingEnumerator;
        }

        public abstract IEnumerator Execute(TestJobData testJobData);
    }
=======
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class TestTaskBase
    {
        public bool SupportsResumingEnumerator;

        protected TestTaskBase(bool supportsResumingEnumerator = false)
        {
            SupportsResumingEnumerator = supportsResumingEnumerator;
        }

        public abstract IEnumerator Execute(TestJobData testJobData);
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}