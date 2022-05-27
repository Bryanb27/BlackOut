<<<<<<< HEAD
#if TEST_FRAMEWORK
using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace Packages.Rider.Editor.UnitTesting
{
  [InitializeOnLoad]
  internal static class CallbackInitializer
  {
    static CallbackInitializer()
    {
      if (CallbackData.instance.isRider)
        ScriptableObject.CreateInstance<TestRunnerApi>().RegisterCallbacks(ScriptableObject.CreateInstance<TestsCallback>(), 0);
    }
  }
}
=======
#if TEST_FRAMEWORK
using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace Packages.Rider.Editor.UnitTesting
{
  [InitializeOnLoad]
  internal static class CallbackInitializer
  {
    static CallbackInitializer()
    {
      if (CallbackData.instance.isRider)
        ScriptableObject.CreateInstance<TestRunnerApi>().RegisterCallbacks(ScriptableObject.CreateInstance<TestsCallback>(), 0);
    }
  }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
#endif