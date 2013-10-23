using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentExample
{
    class Program
    {
        public static void Main()
        {
            String str;
            String nl = Environment.NewLine;
            //
            Console.WriteLine();
            Console.WriteLine("-- Environment members --");

            //  Invoke this sample with an arbitrary set of command line arguments.
            Console.WriteLine("CommandLine: {0}", Environment.CommandLine);

            String[] arguments = Environment.GetCommandLineArgs();
            Console.WriteLine("GetCommandLineArgs: {0}", String.Join(", ", arguments));

            //  <-- Keep this information secure! -->
            Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);

            Console.WriteLine("ExitCode: {0}", Environment.ExitCode);

            Console.WriteLine("HasShutdownStarted: {0}", Environment.HasShutdownStarted);

            //  <-- Keep this information secure! -->
            Console.WriteLine("MachineName: {0}", Environment.MachineName);

            Console.WriteLine("NewLine: {0}  first line{0}  second line{0}  third line",
                                  Environment.NewLine);

            Console.WriteLine("OSVersion: {0}", Environment.OSVersion.ToString());

            Console.WriteLine("StackTrace: '{0}'", Environment.StackTrace);

            //  <-- Keep this information secure! -->
            Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);

            Console.WriteLine("TickCount: {0}", Environment.TickCount);

            //  <-- Keep this information secure! -->
            Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName);

            Console.WriteLine("UserInteractive: {0}", Environment.UserInteractive);

            //  <-- Keep this information secure! -->
            Console.WriteLine("UserName: {0}", Environment.UserName);

            Console.WriteLine("Version: {0}", Environment.Version.ToString());

            Console.WriteLine("WorkingSet: {0}", Environment.WorkingSet);

            Console.Read();
        }
    }
}
