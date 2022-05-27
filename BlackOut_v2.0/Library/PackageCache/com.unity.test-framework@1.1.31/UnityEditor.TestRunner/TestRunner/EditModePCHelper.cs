<<<<<<< HEAD
using System.Collections;
using System.Reflection;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModePcHelper : TestCommandPcHelper
    {
        public override void SetEnumeratorPC(IEnumerator enumerator, int pc)
        {
            GetPCFieldInfo(enumerator).SetValue(enumerator, pc);
        }

        public override int GetEnumeratorPC(IEnumerator enumerator)
        {
            if (enumerator == null)
            {
                return 0;
            }
            return (int)GetPCFieldInfo(enumerator).GetValue(enumerator);
        }

        private FieldInfo GetPCFieldInfo(IEnumerator enumerator)
        {
            var field = enumerator.GetType().GetField("$PC", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field == null) // Roslyn
                field = enumerator.GetType().GetField("<>1__state", BindingFlags.NonPublic | BindingFlags.Instance);

            return field;
        }
    }
}
=======
using System.Collections;
using System.Reflection;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModePcHelper : TestCommandPcHelper
    {
        public override void SetEnumeratorPC(IEnumerator enumerator, int pc)
        {
            GetPCFieldInfo(enumerator).SetValue(enumerator, pc);
        }

        public override int GetEnumeratorPC(IEnumerator enumerator)
        {
            if (enumerator == null)
            {
                return 0;
            }
            return (int)GetPCFieldInfo(enumerator).GetValue(enumerator);
        }

        private FieldInfo GetPCFieldInfo(IEnumerator enumerator)
        {
            var field = enumerator.GetType().GetField("$PC", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field == null) // Roslyn
                field = enumerator.GetType().GetField("<>1__state", BindingFlags.NonPublic | BindingFlags.Instance);

            return field;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
