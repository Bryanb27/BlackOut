<<<<<<< HEAD
using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestRunner.NUnitExtensions
{
    internal static class TestResultExtensions
    {
        public static void RecordPrefixedException(this TestResult testResult, string prefix, Exception ex, ResultState resultState = null)

        {
            if (ex is NUnitException)
            {
                ex = ex.InnerException;
            }

            if (resultState == null)
            {
                resultState = testResult.ResultState == ResultState.Cancelled
                    ? ResultState.Cancelled
                    : ResultState.Error;
            }

            var exceptionMessage = ExceptionHelper.BuildMessage(ex);
            string stackTrace = "--" + prefix + NUnit.Env.NewLine + ExceptionHelper.BuildStackTrace(ex);
            if (testResult.StackTrace != null)
            {
                stackTrace = testResult.StackTrace + NUnit.Env.NewLine + stackTrace;
            }

            if (testResult.Test.IsSuite)
            {
                resultState = resultState.WithSite(FailureSite.TearDown);
            }

            if (ex is ResultStateException)
            {
                exceptionMessage = ex.Message;
                resultState = ((ResultStateException)ex).ResultState;
                stackTrace = StackFilter.Filter(ex.StackTrace);
            }

            string message = (string.IsNullOrEmpty(prefix) ? "" : (prefix + " : ")) + exceptionMessage;
            if (testResult.Message != null)
            {
                message = testResult.Message + NUnit.Env.NewLine + message;
            }

            testResult.SetResult(resultState, message, stackTrace);
        }

        public static void RecordPrefixedError(this TestResult testResult, string prefix, string error, ResultState resultState = null)

        {
            if (resultState == null)
            {
                resultState = testResult.ResultState == ResultState.Cancelled
                    ? ResultState.Cancelled
                    : ResultState.Error;
            }
            
            if (testResult.Test.IsSuite)
            {
                resultState = resultState.WithSite(FailureSite.TearDown);
            }

            string message = (string.IsNullOrEmpty(prefix) ? "" : (prefix + " : ")) + error;
            if (testResult.Message != null)
            {
                message = testResult.Message + NUnit.Env.NewLine + message;
            }

            testResult.SetResult(resultState, message);
        }
    }
=======
using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestRunner.NUnitExtensions
{
    internal static class TestResultExtensions
    {
        public static void RecordPrefixedException(this TestResult testResult, string prefix, Exception ex, ResultState resultState = null)

        {
            if (ex is NUnitException)
            {
                ex = ex.InnerException;
            }

            if (resultState == null)
            {
                resultState = testResult.ResultState == ResultState.Cancelled
                    ? ResultState.Cancelled
                    : ResultState.Error;
            }

            var exceptionMessage = ExceptionHelper.BuildMessage(ex);
            string stackTrace = "--" + prefix + NUnit.Env.NewLine + ExceptionHelper.BuildStackTrace(ex);
            if (testResult.StackTrace != null)
            {
                stackTrace = testResult.StackTrace + NUnit.Env.NewLine + stackTrace;
            }

            if (testResult.Test.IsSuite)
            {
                resultState = resultState.WithSite(FailureSite.TearDown);
            }

            if (ex is ResultStateException)
            {
                exceptionMessage = ex.Message;
                resultState = ((ResultStateException)ex).ResultState;
                stackTrace = StackFilter.Filter(ex.StackTrace);
            }

            string message = (string.IsNullOrEmpty(prefix) ? "" : (prefix + " : ")) + exceptionMessage;
            if (testResult.Message != null)
            {
                message = testResult.Message + NUnit.Env.NewLine + message;
            }

            testResult.SetResult(resultState, message, stackTrace);
        }

        public static void RecordPrefixedError(this TestResult testResult, string prefix, string error, ResultState resultState = null)

        {
            if (resultState == null)
            {
                resultState = testResult.ResultState == ResultState.Cancelled
                    ? ResultState.Cancelled
                    : ResultState.Error;
            }
            
            if (testResult.Test.IsSuite)
            {
                resultState = resultState.WithSite(FailureSite.TearDown);
            }

            string message = (string.IsNullOrEmpty(prefix) ? "" : (prefix + " : ")) + error;
            if (testResult.Message != null)
            {
                message = testResult.Message + NUnit.Env.NewLine + message;
            }

            testResult.SetResult(resultState, message);
        }
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}