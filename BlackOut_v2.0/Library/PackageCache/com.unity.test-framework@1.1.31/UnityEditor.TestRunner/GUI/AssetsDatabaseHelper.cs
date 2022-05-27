<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
