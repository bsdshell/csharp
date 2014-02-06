using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace whereExample
{
    public class MyClass<T> where T : IComparable, new()
    {
        //The following line is not possible without new() constraint
        T item = new T();
    }
    class Program
    {
        static void Main(string[]  args)
        {
            System.Console.WriteLine("where constraints generic type");
            System.Console.ReadLine();
        }
    }
}
