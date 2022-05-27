<<<<<<< HEAD
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyEditModeRunTask : TestTaskBase
    {
        public LegacyEditModeRunTask() : base(true)
        {
            
        }
        
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var testLauncher = new EditModeLauncher(testJobData.executionSettings.filters, TestPlatform.EditMode, testJobData.executionSettings.runSynchronously);
            testJobData.editModeRunner = testLauncher.m_EditModeRunner;
            testLauncher.Run();
            
            while (testJobData.editModeRunner != null && !testJobData.editModeRunner.RunFinished)
            {
                yield return null;
            }
        }
    }
=======
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyEditModeRunTask : TestTaskBase
    {
        public LegacyEditModeRunTask() : base(true)
        {
            
        }
        
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var testLauncher = new EditModeLauncher(testJobData.executionSettings.filters, TestPlatform.EditMode, testJobData.executionSettings.runSynchronously);
            testJobData.editModeRunner = testLauncher.m_EditModeRunner;
            testLauncher.Run();
            
            while (testJobData.editModeRunner != null && !testJobData.editModeRunner.RunFinished)
            {
                yield return null;
            }
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}