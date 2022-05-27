<<<<<<< HEAD
namespace Packages.Rider.Editor.ProjectGeneration {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string name)
    {
      return SolutionGuidGenerator.GuidForProject(name);
    }
  }
}
=======
namespace Packages.Rider.Editor.ProjectGeneration {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string name)
    {
      return SolutionGuidGenerator.GuidForProject(name);
    }
  }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
