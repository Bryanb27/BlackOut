<<<<<<< HEAD
using System;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.TestRun
{
    [Serializable]
    internal class TestJobData
    {
        [SerializeField] 
        public string guid;
        
        [SerializeField]
        public string startTime;
        
        [SerializeField] 
        public int taskIndex;

        [SerializeField] 
        public int taskPC;

        [SerializeField] 
        public bool isRunning;
        
        [SerializeField]
        public ExecutionSettings executionSettings;
        
        [SerializeField]
        public string[] existingFiles;

        [SerializeField] 
        public int undoGroup = -1;

        [SerializeField] 
        public EditModeRunner editModeRunner;

        [NonSerialized] 
        public bool isHandledByRunner;
        
        public ITest testTree;

        public TestJobData(ExecutionSettings settings)
        {
            guid = Guid.NewGuid().ToString();
            executionSettings = settings;
            isRunning = false;
            taskIndex = 0;
            taskPC = 0;
            startTime = DateTime.Now.ToString("o");
        }
    }
}
=======
using System;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.TestRun
{
    [Serializable]
    internal class TestJobData
    {
        [SerializeField] 
        public string guid;
        
        [SerializeField]
        public string startTime;
        
        [SerializeField] 
        public int taskIndex;

        [SerializeField] 
        public int taskPC;

        [SerializeField] 
        public bool isRunning;
        
        [SerializeField]
        public ExecutionSettings executionSettings;
        
        [SerializeField]
        public string[] existingFiles;

        [SerializeField] 
        public int undoGroup = -1;

        [SerializeField] 
        public EditModeRunner editModeRunner;

        [NonSerialized] 
        public bool isHandledByRunner;
        
        public ITest testTree;

        public TestJobData(ExecutionSettings settings)
        {
            guid = Guid.NewGuid().ToString();
            executionSettings = settings;
            isRunning = false;
            taskIndex = 0;
            taskPC = 0;
            startTime = DateTime.Now.ToString("o");
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
