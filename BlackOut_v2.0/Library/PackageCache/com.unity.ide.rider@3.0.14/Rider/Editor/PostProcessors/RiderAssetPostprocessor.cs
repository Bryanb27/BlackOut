<<<<<<< HEAD
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  internal class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderInstallation(path))
        return !ProjectGeneration.ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
=======
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  internal class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderInstallation(path))
        return !ProjectGeneration.ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}