<<<<<<< HEAD
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Unity.Services.Core.Editor")]

// Test assemblies
#if UNITY_INCLUDE_TESTS
[assembly: InternalsVisibleTo("Unity.Services.Core.EditorTests")]
[assembly: InternalsVisibleTo("Unity.Services.Core.TestUtils.EditorTests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif
=======
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Unity.Services.Core.Editor")]

// Test assemblies
#if UNITY_INCLUDE_TESTS
[assembly: InternalsVisibleTo("Unity.Services.Core.EditorTests")]
[assembly: InternalsVisibleTo("Unity.Services.Core.TestUtils.EditorTests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
