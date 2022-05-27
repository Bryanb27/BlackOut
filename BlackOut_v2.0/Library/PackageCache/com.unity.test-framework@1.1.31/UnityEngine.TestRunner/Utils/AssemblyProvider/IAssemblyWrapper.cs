<<<<<<< HEAD
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal interface IAssemblyWrapper
    {
        Assembly Assembly { get; }
        AssemblyName Name { get; }
        string Location { get; }
        AssemblyName[] GetReferencedAssemblies();
    }
}
=======
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal interface IAssemblyWrapper
    {
        Assembly Assembly { get; }
        AssemblyName Name { get; }
        string Location { get; }
        AssemblyName[] GetReferencedAssemblies();
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
