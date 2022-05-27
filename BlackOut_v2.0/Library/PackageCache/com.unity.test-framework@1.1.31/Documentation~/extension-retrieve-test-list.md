<<<<<<< HEAD
# How to retrieve the list of tests
It is possible to use the [TestRunnerApi](./reference-test-runner-api.md) to retrieve the test tree for a given test mode (**Edit Mode** or **Play Mode**). You can retrieve the test tree by invoking `RetrieveTestList` with the desired `TestMode` and a callback action, with an [ITestAdaptor](./reference-itest-adaptor.md) representing the test tree.

## Example
The following example retrieves the test tree for Edit Mode tests and prints the number of total test cases:
``` C#
var api = ScriptableObject.CreateInstance<TestRunnerApi>();
api.RetrieveTestList(TestMode.EditMode, (testRoot) =>
{
    Debug.Log(string.Format("Tree contains {0} tests.", testRoot.TestCaseCount));
});
```

=======
# How to retrieve the list of tests
It is possible to use the [TestRunnerApi](./reference-test-runner-api.md) to retrieve the test tree for a given test mode (**Edit Mode** or **Play Mode**). You can retrieve the test tree by invoking `RetrieveTestList` with the desired `TestMode` and a callback action, with an [ITestAdaptor](./reference-itest-adaptor.md) representing the test tree.

## Example
The following example retrieves the test tree for Edit Mode tests and prints the number of total test cases:
``` C#
var api = ScriptableObject.CreateInstance<TestRunnerApi>();
api.RetrieveTestList(TestMode.EditMode, (testRoot) =>
{
    Debug.Log(string.Format("Tree contains {0} tests.", testRoot.TestCaseCount));
});
```

>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
