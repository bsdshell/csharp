using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsAndAs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add(new DerivedClass());
            list.Add(new DerivedClass());
            list.Add(new CrazyClass());
            BadCast(list);
            GoodCast(list);
            Console.ReadLine();
        }

        public static void BadCast(List<object> list)
        {
            foreach (Object obj in list)
            {
                if (obj is BaseClass)
                {
                    DerivedClass derivedClass = obj as DerivedClass;
                    Console.WriteLine("duplicating cast operation with [is] and [as]");
                }
            }
        }

        public static void GoodCast(List<object> list)
        {
            foreach (Object obj in list)
            {
                DerivedClass derivedClass = obj as DerivedClass;
                if (derivedClass != null)
                {
                    System.Console.WriteLine("Good cast with as");
                }
            }
        }
    }

    class BaseClass{}
    class DerivedClass : BaseClass{}
    class CrazyClass{}
}
