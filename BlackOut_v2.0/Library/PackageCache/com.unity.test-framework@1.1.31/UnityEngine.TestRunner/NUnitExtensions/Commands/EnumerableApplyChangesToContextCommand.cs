<<<<<<< HEAD

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEngine.TestTools
{
    internal class EnumerableApplyChangesToContextCommand : ApplyChangesToContextCommand, IEnumerableTestMethodCommand
    {
        public EnumerableApplyChangesToContextCommand(TestCommand innerCommand, IEnumerable<IApplyToContext> changes)
            : base(innerCommand, changes) { }

        public IEnumerable ExecuteEnumerable(ITestExecutionContext context)
        {
            ApplyChanges(context);

            if (innerCommand is IEnumerableTestMethodCommand)
            {
                var executeEnumerable = ((IEnumerableTestMethodCommand)innerCommand).ExecuteEnumerable(context);
                foreach (var iterator in executeEnumerable)
                {
                    yield return iterator;
                }
            }
            else
            {
                context.CurrentResult = innerCommand.Execute(context);
            }
        }
    }
=======

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEngine.TestTools
{
    internal class EnumerableApplyChangesToContextCommand : ApplyChangesToContextCommand, IEnumerableTestMethodCommand
    {
        public EnumerableApplyChangesToContextCommand(TestCommand innerCommand, IEnumerable<IApplyToContext> changes)
            : base(innerCommand, changes) { }

        public IEnumerable ExecuteEnumerable(ITestExecutionContext context)
        {
            ApplyChanges(context);

            if (innerCommand is IEnumerableTestMethodCommand)
            {
                var executeEnumerable = ((IEnumerableTestMethodCommand)innerCommand).ExecuteEnumerable(context);
                foreach (var iterator in executeEnumerable)
                {
                    yield return iterator;
                }
            }
            else
            {
                context.CurrentResult = innerCommand.Execute(context);
            }
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}