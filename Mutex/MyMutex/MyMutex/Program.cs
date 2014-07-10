using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.SqlServer.Server;

namespace MyMutex
{
    class Program
    {
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            int numThread = 5;
            for (int i = 0; i < numThread; i++)
            {
                Thread thread = new Thread(new ThreadStart(Run));
                thread.Name = string.Format("Thread {0}", i);
                thread.Start();
            }
            Console.ReadLine();
        }

        static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                UseResource();
                Console.WriteLine("            [{0} tries to access the protected area]", Thread.CurrentThread.Name);
            }
        }
        static void UseResource()
        {
            //Wait 1 second to enter the protected area
            if (mutex.WaitOne(1000))
            {
                Console.WriteLine("{0} has entered the protected area", Thread.CurrentThread.Name);
                Thread.Sleep(2000);

                Console.WriteLine("{0} is leaving the protected area", Thread.CurrentThread.Name);

                //Release the mutex
                mutex.ReleaseMutex();
                Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);
            }
        }
    }
}
