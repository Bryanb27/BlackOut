<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class FileCleanupVerifierTaskBase : TestTaskBase
    {
        internal Func<string[]> GetAllAssetPathsAction = AssetDatabase.GetAllAssetPaths;
        
        protected string[] GetAllFilesInAssetsDirectory()
        {
            return GetAllAssetPathsAction();
        }
    }
=======
using System;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class FileCleanupVerifierTaskBase : TestTaskBase
    {
        internal Func<string[]> GetAllAssetPathsAction = AssetDatabase.GetAllAssetPaths;
        
        protected string[] GetAllFilesInAssetsDirectory()
        {
            return GetAllAssetPathsAction();
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}