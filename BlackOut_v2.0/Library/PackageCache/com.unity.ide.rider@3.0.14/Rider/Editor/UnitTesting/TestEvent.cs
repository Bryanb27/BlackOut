<<<<<<< HEAD
#if TEST_FRAMEWORK
using System;
using NUnit.Framework.Interfaces;

namespace Packages.Rider.Editor.UnitTesting
{
  /// <summary>
  /// Is used by Rider Unity plugin by reflection
  /// </summary>
  [Serializable]
  internal enum EventType { TestStarted, TestFinished, RunFinished, RunStarted } // do not reorder

  /// <summary>
  /// Is used by Rider Unity plugin by reflection
  /// </summary>
  [Serializable]
  internal class TestEvent
  {
    public EventType type;
    public string id;
    public string assemblyName;
    public string output;
    public TestStatus testStatus;
    public double duration;
    public string parentId;
    
    public TestEvent(EventType type, string id, string assemblyName, string output, double duration, TestStatus testStatus, string parentID)
    {
      this.type = type;
      this.id = id;
      this.assemblyName = assemblyName;
      this.output = output;
      this.testStatus = testStatus;
      this.duration = duration;
      parentId = parentID;
    }
  }
}
=======
#if TEST_FRAMEWORK
using System;
using NUnit.Framework.Interfaces;

namespace Packages.Rider.Editor.UnitTesting
{
  /// <summary>
  /// Is used by Rider Unity plugin by reflection
  /// </summary>
  [Serializable]
  internal enum EventType { TestStarted, TestFinished, RunFinished, RunStarted } // do not reorder

  /// <summary>
  /// Is used by Rider Unity plugin by reflection
  /// </summary>
  [Serializable]
  internal class TestEvent
  {
    public EventType type;
    public string id;
    public string assemblyName;
    public string output;
    public TestStatus testStatus;
    public double duration;
    public string parentId;
    
    public TestEvent(EventType type, string id, string assemblyName, string output, double duration, TestStatus testStatus, string parentID)
    {
      this.type = type;
      this.id = id;
      this.assemblyName = assemblyName;
      this.output = output;
      this.testStatus = testStatus;
      this.duration = duration;
      parentId = parentID;
    }
  }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
#endif