<<<<<<< HEAD
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
=======
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
