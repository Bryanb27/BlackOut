<<<<<<< HEAD
using System;
using System.Collections.Generic;

namespace UnityEngine.TestTools.Logging
{
    internal interface ILogScope : IDisposable
    {
        Queue<LogMatch> ExpectedLogs { get; set; }
        List<LogEvent> AllLogs { get; }
        List<LogEvent> FailingLogs { get; }
        bool IgnoreFailingMessages { get; set; }
        bool IsNUnitException { get; }
        bool IsNUnitSuccessException { get; }
        bool IsNUnitInconclusiveException { get; }
        bool IsNUnitIgnoreException { get; }
        string NUnitExceptionMessage { get; }
        void AddLog(string message, string stacktrace, LogType type);
        bool AnyFailingLogs();
        void ProcessExpectedLogs();
        void NoUnexpectedReceived();
    }
}
=======
using System;
using System.Collections.Generic;

namespace UnityEngine.TestTools.Logging
{
    internal interface ILogScope : IDisposable
    {
        Queue<LogMatch> ExpectedLogs { get; set; }
        List<LogEvent> AllLogs { get; }
        List<LogEvent> FailingLogs { get; }
        bool IgnoreFailingMessages { get; set; }
        bool IsNUnitException { get; }
        bool IsNUnitSuccessException { get; }
        bool IsNUnitInconclusiveException { get; }
        bool IsNUnitIgnoreException { get; }
        string NUnitExceptionMessage { get; }
        void AddLog(string message, string stacktrace, LogType type);
        bool AnyFailingLogs();
        void ProcessExpectedLogs();
        void NoUnexpectedReceived();
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
