<<<<<<< HEAD
using System.Collections.Generic;

namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IGenerator
  {
    bool SyncIfNeeded(IEnumerable<string> affectedFiles, IEnumerable<string> reimportedFiles, bool checkProjectFiles = false);
    void Sync();
    bool HasSolutionBeenGenerated();
    string SolutionFile();
    IAssemblyNameProvider AssemblyNameProvider { get; }
  }
=======
using System.Collections.Generic;

namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IGenerator
  {
    bool SyncIfNeeded(IEnumerable<string> affectedFiles, IEnumerable<string> reimportedFiles, bool checkProjectFiles = false);
    void Sync();
    bool HasSolutionBeenGenerated();
    string SolutionFile();
    IAssemblyNameProvider AssemblyNameProvider { get; }
  }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}