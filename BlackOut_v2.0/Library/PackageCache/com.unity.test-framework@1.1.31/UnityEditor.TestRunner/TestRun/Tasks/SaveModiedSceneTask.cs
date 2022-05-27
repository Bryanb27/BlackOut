<<<<<<< HEAD
using System;
using System.Collections;
using UnityEditor.SceneManagement;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveModiedSceneTask : TestTaskBase
    {
        internal Func<bool> SaveCurrentModifiedScenesIfUserWantsTo =
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var cancelled = !SaveCurrentModifiedScenesIfUserWantsTo();
            if (cancelled)
            {
                throw new TestRunCanceledException();
            }

            yield break;
        }
    }
=======
using System;
using System.Collections;
using UnityEditor.SceneManagement;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveModiedSceneTask : TestTaskBase
    {
        internal Func<bool> SaveCurrentModifiedScenesIfUserWantsTo =
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var cancelled = !SaveCurrentModifiedScenesIfUserWantsTo();
            if (cancelled)
            {
                throw new TestRunCanceledException();
            }

            yield break;
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}