<<<<<<< HEAD
﻿using System;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using Unity.Profiling;

namespace UnityEngine.TestTools
{
    internal class UnityTestMethodCommand : TestMethodCommand
    {
        public UnityTestMethodCommand(TestMethod testMethod)
            : base(testMethod) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            using (new ProfilerMarker(Test.FullName).Auto())
                return base.Execute(context);
        }
    }
}
=======
﻿using System;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using Unity.Profiling;

namespace UnityEngine.TestTools
{
    internal class UnityTestMethodCommand : TestMethodCommand
    {
        public UnityTestMethodCommand(TestMethod testMethod)
            : base(testMethod) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            using (new ProfilerMarker(Test.FullName).Auto())
                return base.Execute(context);
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
