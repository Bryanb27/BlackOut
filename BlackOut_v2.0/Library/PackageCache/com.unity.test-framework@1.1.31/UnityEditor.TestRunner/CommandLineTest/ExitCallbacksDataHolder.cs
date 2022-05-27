<<<<<<< HEAD
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class ExitCallbacksDataHolder : ScriptableSingleton<ExitCallbacksDataHolder>
    {
        [SerializeField] 
        public bool AnyTestsExecuted;
        [SerializeField]
        public bool RunFailed;
    }
=======
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class ExitCallbacksDataHolder : ScriptableSingleton<ExitCallbacksDataHolder>
    {
        [SerializeField] 
        public bool AnyTestsExecuted;
        [SerializeField]
        public bool RunFailed;
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}