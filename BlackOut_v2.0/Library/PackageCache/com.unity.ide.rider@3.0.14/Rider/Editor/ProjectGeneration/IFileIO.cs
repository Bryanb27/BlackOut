<<<<<<< HEAD
namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IFileIO
  {
    bool Exists(string fileName);

    string ReadAllText(string fileName);
    void WriteAllText(string path, string content);

    string EscapedRelativePathFor(string file, string projectDirectory);
  }
=======
namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IFileIO
  {
    bool Exists(string fileName);

    string ReadAllText(string fileName);
    void WriteAllText(string path, string content);

    string EscapedRelativePathFor(string file, string projectDirectory);
  }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}