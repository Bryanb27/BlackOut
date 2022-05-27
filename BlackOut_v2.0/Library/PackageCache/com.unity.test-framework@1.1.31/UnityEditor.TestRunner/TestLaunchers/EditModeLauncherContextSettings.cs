<<<<<<< HEAD
using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModeLauncherContextSettings : IDisposable
    {
        private bool m_RunInBackground;

        public EditModeLauncherContextSettings()
        {
            SetupProjectParameters();
        }

        public void Dispose()
        {
            CleanupProjectParameters();
        }

        private void SetupProjectParameters()
        {
            m_RunInBackground = Application.runInBackground;
            Application.runInBackground = true;
        }

        private void CleanupProjectParameters()
        {
            Application.runInBackground = m_RunInBackground;
        }
    }
}
=======
using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModeLauncherContextSettings : IDisposable
    {
        private bool m_RunInBackground;

        public EditModeLauncherContextSettings()
        {
            SetupProjectParameters();
        }

        public void Dispose()
        {
            CleanupProjectParameters();
        }

        private void SetupProjectParameters()
        {
            m_RunInBackground = Application.runInBackground;
            Application.runInBackground = true;
        }

        private void CleanupProjectParameters()
        {
            Application.runInBackground = m_RunInBackground;
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
