using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace StopWatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> stringList = new List<String>();
            for (int i = 0; i < 1000000; i++)
            {
                stringList.Add(i + "");
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (String str in stringList)
            {
                Console.WriteLine(str);
            }
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.ReadLine();
        }
    }
}