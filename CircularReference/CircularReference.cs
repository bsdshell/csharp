using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularReference
{
    public class MyClassA
    {
        MyClassB b;
        public MyClassA(MyClassB b)
        {
            this.b = b;
        }
    }
    public class MyClassB
    {
        MyClassA a;
        public MyClassB()
        {
            a = new MyClassA(this);
        }
    }

    class CircularReference
    {
        static void Main(string[] args)
        {
            MyClassB b = new MyClassB();
            System.Console.WriteLine("MyClassA and MyClassB are connected(Circular Reference)");
            System.Console.ReadLine();
        }
    }
}
