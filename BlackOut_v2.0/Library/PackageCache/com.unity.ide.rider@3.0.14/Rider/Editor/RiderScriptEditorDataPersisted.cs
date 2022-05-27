<<<<<<< HEAD
using System;
using UnityEditor;
using UnityEngine;

namespace Packages.Rider.Editor
{
#if UNITY_2020_1_OR_NEWER // API doesn't exist in 2019.4
  [FilePath("Library/com.unity.ide.rider/PersistedState.asset", FilePathAttribute.Location.ProjectFolder)]
#endif
  internal class RiderScriptEditorPersistedState : ScriptableSingleton<RiderScriptEditorPersistedState>
  {
    [SerializeField] private long lastWriteTicks;

    public DateTime? LastWrite
    {
      get => DateTime.FromBinary(lastWriteTicks);
      set
      {
        if (!value.HasValue) return;
        lastWriteTicks = value.Value.ToBinary();
        Save(true);
      }
    }
  }
=======
using System;
using UnityEditor;
using UnityEngine;

namespace Packages.Rider.Editor
{
#if UNITY_2020_1_OR_NEWER // API doesn't exist in 2019.4
  [FilePath("Library/com.unity.ide.rider/PersistedState.asset", FilePathAttribute.Location.ProjectFolder)]
#endif
  internal class RiderScriptEditorPersistedState : ScriptableSingleton<RiderScriptEditorPersistedState>
  {
    [SerializeField] private long lastWriteTicks;

    public DateTime? LastWrite
    {
      get => DateTime.FromBinary(lastWriteTicks);
      set
      {
        if (!value.HasValue) return;
        lastWriteTicks = value.Value.ToBinary();
        Save(true);
      }
    }
  }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}