<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Builders;

namespace UnityEngine.TestTools
{
    internal class UnityCombinatorialStrategy : CombinatorialStrategy, ICombiningStrategy
    {
        public new IEnumerable<ITestCaseData> GetTestCases(IEnumerable[] sources)
        {
            var testCases = base.GetTestCases(sources);
            foreach (var testCase in testCases)
            {
                testCase.GetType().GetProperty("ExpectedResult").SetValue(testCase, new object(), null);
            }
            return testCases;
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Builders;

namespace UnityEngine.TestTools
{
    internal class UnityCombinatorialStrategy : CombinatorialStrategy, ICombiningStrategy
    {
        public new IEnumerable<ITestCaseData> GetTestCases(IEnumerable[] sources)
        {
            var testCases = base.GetTestCases(sources);
            foreach (var testCase in testCases)
            {
                testCase.GetType().GetProperty("ExpectedResult").SetValue(testCase, new object(), null);
            }
            return testCases;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
