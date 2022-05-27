<<<<<<< HEAD
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PrebuildSetupAttributeFinder : AttributeFinderBase<IPrebuildSetup, PrebuildSetupAttribute>
    {
        public PrebuildSetupAttributeFinder() : base((attribute) => attribute.TargetClass) {}
    }
}
=======
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PrebuildSetupAttributeFinder : AttributeFinderBase<IPrebuildSetup, PrebuildSetupAttribute>
    {
        public PrebuildSetupAttributeFinder() : base((attribute) => attribute.TargetClass) {}
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
