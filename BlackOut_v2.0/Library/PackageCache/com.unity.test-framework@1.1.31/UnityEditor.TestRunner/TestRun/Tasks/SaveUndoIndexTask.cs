<<<<<<< HEAD
using System;
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveUndoIndexTask : TestTaskBase
    {
        internal Func<int> GetUndoGroup = Undo.GetCurrentGroup;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.undoGroup = GetUndoGroup();
            yield break;
        }
    }
=======
using System;
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveUndoIndexTask : TestTaskBase
    {
        internal Func<int> GetUndoGroup = Undo.GetCurrentGroup;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.undoGroup = GetUndoGroup();
            yield break;
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}