<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
=======
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
