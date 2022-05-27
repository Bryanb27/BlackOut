<<<<<<< HEAD
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class RegisterFilesForCleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.existingFiles = GetAllFilesInAssetsDirectory();
            yield return null;
        }
    }
=======
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class RegisterFilesForCleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.existingFiles = GetAllFilesInAssetsDirectory();
            yield return null;
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}