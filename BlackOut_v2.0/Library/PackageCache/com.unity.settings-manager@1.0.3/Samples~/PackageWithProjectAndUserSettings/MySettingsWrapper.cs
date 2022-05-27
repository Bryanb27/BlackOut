<<<<<<< HEAD
﻿using UnityEditor.SettingsManagement;

namespace UnityEditor.SettingsManagement.Examples
{
    // Usually you will only have a single Settings instance, so it is convenient to define a UserSetting<T> implementation
    // that points to your instance. In this way you avoid having to pass the Settings parameter in setting field definitions.
    class MySetting<T> : UserSetting<T>
    {
        public MySetting(string key, T value, SettingsScope scope = SettingsScope.Project)
            : base(MySettingsManager.instance, key, value, scope)
        {}

        MySetting(Settings settings, string key, T value, SettingsScope scope = SettingsScope.Project)
            : base(settings, key, value, scope) { }
    }
}
=======
﻿using UnityEditor.SettingsManagement;

namespace UnityEditor.SettingsManagement.Examples
{
    // Usually you will only have a single Settings instance, so it is convenient to define a UserSetting<T> implementation
    // that points to your instance. In this way you avoid having to pass the Settings parameter in setting field definitions.
    class MySetting<T> : UserSetting<T>
    {
        public MySetting(string key, T value, SettingsScope scope = SettingsScope.Project)
            : base(MySettingsManager.instance, key, value, scope)
        {}

        MySetting(Settings settings, string key, T value, SettingsScope scope = SettingsScope.Project)
            : base(settings, key, value, scope) { }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
