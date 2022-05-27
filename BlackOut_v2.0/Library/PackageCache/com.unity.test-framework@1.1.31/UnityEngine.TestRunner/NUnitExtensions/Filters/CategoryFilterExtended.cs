<<<<<<< HEAD
using System.Collections;
using System.Linq;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Filters;

namespace UnityEngine.TestRunner.NUnitExtensions.Filters
{
    internal class CategoryFilterExtended : CategoryFilter
    {
        public static string k_DefaultCategory = "Uncategorized";

        public CategoryFilterExtended(string name) : base(name)
        {
        }

        public override bool Match(ITest test)
        {
            IList testCategories = test.Properties[PropertyNames.Category].Cast<string>().ToList();

            if (test is TestMethod)
            {
                // Do not count tests with no attribute as Uncategorized if test fixture class has at least one attribute
                // The test inherits the attribute from the test fixture
                IList fixtureCategories = test.Parent.Properties[PropertyNames.Category].Cast<string>().ToList();
                if (fixtureCategories.Count > 0)
                    return false;
            }

            if (testCategories.Count == 0 && ExpectedValue == k_DefaultCategory && test is TestMethod)
                return true;

            return base.Match(test);
        }
    }
}
=======
using System.Collections;
using System.Linq;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Filters;

namespace UnityEngine.TestRunner.NUnitExtensions.Filters
{
    internal class CategoryFilterExtended : CategoryFilter
    {
        public static string k_DefaultCategory = "Uncategorized";

        public CategoryFilterExtended(string name) : base(name)
        {
        }

        public override bool Match(ITest test)
        {
            IList testCategories = test.Properties[PropertyNames.Category].Cast<string>().ToList();

            if (test is TestMethod)
            {
                // Do not count tests with no attribute as Uncategorized if test fixture class has at least one attribute
                // The test inherits the attribute from the test fixture
                IList fixtureCategories = test.Parent.Properties[PropertyNames.Category].Cast<string>().ToList();
                if (fixtureCategories.Count > 0)
                    return false;
            }

            if (testCategories.Count == 0 && ExpectedValue == k_DefaultCategory && test is TestMethod)
                return true;

            return base.Match(test);
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
