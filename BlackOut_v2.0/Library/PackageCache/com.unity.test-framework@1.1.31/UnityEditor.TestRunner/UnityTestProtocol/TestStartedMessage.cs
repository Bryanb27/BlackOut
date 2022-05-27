<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestStartedMessage : Message
    {
        public string name;
        public TestState state;

        public TestStartedMessage()
        {
            type = "TestStatus";
            phase = "Begin";
            state = TestState.Inconclusive;
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestStartedMessage : Message
    {
        public string name;
        public TestState state;

        public TestStartedMessage()
        {
            type = "TestStatus";
            phase = "Begin";
            state = TestState.Inconclusive;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
