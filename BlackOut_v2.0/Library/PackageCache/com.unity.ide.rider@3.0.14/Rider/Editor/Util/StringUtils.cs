<<<<<<< HEAD
using System.IO;

namespace Packages.Rider.Editor.Util
{
  internal static class StringUtils
  {
    public static string NormalizePath(this string path)
    {
      return path.Replace(Path.DirectorySeparatorChar == '\\'
        ? '/'
        : '\\', Path.DirectorySeparatorChar);
    }
  }
=======
using System.IO;

namespace Packages.Rider.Editor.Util
{
  internal static class StringUtils
  {
    public static string NormalizePath(this string path)
    {
      return path.Replace(Path.DirectorySeparatorChar == '\\'
        ? '/'
        : '\\', Path.DirectorySeparatorChar);
    }
  }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}