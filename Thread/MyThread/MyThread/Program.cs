using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyThread
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();

            Thread thread1 = new Thread(()=>c.print("name1"));
            Thread thread2 = new Thread(() => c.print("name2"));
            

            thread1.Start();
            thread2.Start();

            System.Console.ReadLine();
        }
    }

    class MyClass
    {
        public void print(string name)
        {
            int i=0;
            while(true)
            {                
                System.Console.WriteLine("{0}[{1}]", name, i);
                Thread.Sleep(1000);
                i++;
            }
        }
    }
}
