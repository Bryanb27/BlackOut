<<<<<<< HEAD
using System.Collections.Generic;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestPlanMessage : Message
    {
        public List<string> tests;

        public TestPlanMessage()
        {
            type = "TestPlan";
        }
    }
}
=======
using System.Collections.Generic;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestPlanMessage : Message
    {
        public List<string> tests;

        public TestPlanMessage()
        {
            type = "TestPlan";
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
