
using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int numInterator = 100000;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            UsingStringConcatenation(numInterator);


            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds/10);

            Console.WriteLine("RunTime " + elapsedTime);

            stopWatch = new Stopwatch();
            stopWatch.Start();

            UsingStrinbBuilder(numInterator);

            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds/10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.ReadLine();
        }

        private static void UsingStringConcatenation(int numInterator)
        {
            string str = "";
            for (int i = 0; i < numInterator; i++)
            {
                str += "[my string]";
            }
        }

        private static void UsingStrinbBuilder(int numInterator)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numInterator; i++)
            {
                sb.Append("[my string]");
            }
        }
    }
}
