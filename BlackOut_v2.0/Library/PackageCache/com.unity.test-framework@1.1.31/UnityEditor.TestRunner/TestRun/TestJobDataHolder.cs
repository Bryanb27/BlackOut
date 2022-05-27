<<<<<<< HEAD
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.TestRun
{
    internal class TestJobDataHolder : ScriptableSingleton<TestJobDataHolder>
    {
        [SerializeField]
        public List<TestJobData> TestRuns = new List<TestJobData>();
        
        [InitializeOnLoadMethod]
        private static void ResumeRunningJobs()
        {
            foreach (var testRun in instance.TestRuns.ToArray())
            {
                if (testRun.isRunning)
                {
                    var runner = new TestJobRunner();
                    runner.RunJob(testRun);
                }
                else
                {
                    instance.TestRuns.Remove(testRun);
                }
            }
        }
    }
=======
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.TestRun
{
    internal class TestJobDataHolder : ScriptableSingleton<TestJobDataHolder>
    {
        [SerializeField]
        public List<TestJobData> TestRuns = new List<TestJobData>();
        
        [InitializeOnLoadMethod]
        private static void ResumeRunningJobs()
        {
            foreach (var testRun in instance.TestRuns.ToArray())
            {
                if (testRun.isRunning)
                {
                    var runner = new TestJobRunner();
                    runner.RunJob(testRun);
                }
                else
                {
                    instance.TestRuns.Remove(testRun);
                }
            }
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}