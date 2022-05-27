<<<<<<< HEAD
﻿using System.IO;

namespace Rider.Editor.Util
{
  internal static class RiderPathUtil
  {
    public static bool IsRiderDevEditor(string editorPath)
    {
      if (editorPath == null)
        return false;
      return "rider-dev".Equals(Path.GetFileNameWithoutExtension(editorPath));
    }
  }
=======
﻿using System.IO;

namespace Rider.Editor.Util
{
  internal static class RiderPathUtil
  {
    public static bool IsRiderDevEditor(string editorPath)
    {
      if (editorPath == null)
        return false;
      return "rider-dev".Equals(Path.GetFileNameWithoutExtension(editorPath));
    }
  }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}