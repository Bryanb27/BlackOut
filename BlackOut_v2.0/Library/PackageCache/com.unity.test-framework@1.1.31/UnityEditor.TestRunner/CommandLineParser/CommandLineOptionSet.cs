<<<<<<< HEAD
using System;

namespace UnityEditor.TestRunner.CommandLineParser
{
    internal class CommandLineOptionSet
    {
        ICommandLineOption[] m_Options;

        public CommandLineOptionSet(params ICommandLineOption[] options)
        {
            m_Options = options;
        }

        public void Parse(string[] args)
        {
            var i = 0;
            while (i < args.Length)
            {
                var arg = args[i];
                if (!arg.StartsWith("-"))
                {
                    i++;
                    continue;
                }

                string value = null;
                if (i + 1 < args.Length && !args[i + 1].StartsWith("-"))
                {
                    value = args[i + 1];
                    i++;
                }

                ApplyValueToMatchingOptions(arg, value);
                i++;
            }
        }

        private void ApplyValueToMatchingOptions(string argName, string value)
        {
            foreach (var option in m_Options)
            {
                if ("-" + option.ArgName == argName)
                {
                    option.ApplyValue(value);
                }
            }
        }
    }
}
=======
using System;

namespace UnityEditor.TestRunner.CommandLineParser
{
    internal class CommandLineOptionSet
    {
        ICommandLineOption[] m_Options;

        public CommandLineOptionSet(params ICommandLineOption[] options)
        {
            m_Options = options;
        }

        public void Parse(string[] args)
        {
            var i = 0;
            while (i < args.Length)
            {
                var arg = args[i];
                if (!arg.StartsWith("-"))
                {
                    i++;
                    continue;
                }

                string value = null;
                if (i + 1 < args.Length && !args[i + 1].StartsWith("-"))
                {
                    value = args[i + 1];
                    i++;
                }

                ApplyValueToMatchingOptions(arg, value);
                i++;
            }
        }

        private void ApplyValueToMatchingOptions(string argName, string value)
        {
            foreach (var option in m_Options)
            {
                if ("-" + option.ArgName == argName)
                {
                    option.ApplyValue(value);
                }
            }
        }
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
