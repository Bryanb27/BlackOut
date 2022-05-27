<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TestTools.TestRunner.GUI;

namespace TestRunner.Callbacks
{
    internal class WindowResultUpdaterDataHolder : ScriptableSingleton<WindowResultUpdaterDataHolder>
    {
        public List<TestRunnerResult> CachedResults = new List<TestRunnerResult>();
    }
=======
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TestTools.TestRunner.GUI;

namespace TestRunner.Callbacks
{
    internal class WindowResultUpdaterDataHolder : ScriptableSingleton<WindowResultUpdaterDataHolder>
    {
        public List<TestRunnerResult> CachedResults = new List<TestRunnerResult>();
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}