using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numlist1 = new int[] {1, 2, 3, 4, 5};
            int[] numlist2 = new int[] {4, 5, 6, 3, 8};
            var unionList = numlist1.Union(numlist2).ToList();
            var intersectList = numlist1.Intersect(numlist2).ToList();
            var exceptList = numlist1.Except(numlist2);

            Console.WriteLine("numlist1:");
            foreach (int n in numlist1)
            {
                Console.Write("[{0}]", n);
            }
            Console.WriteLine("\n");

            Console.WriteLine("numlist2:");
            foreach (int n in numlist2)
            {
                Console.Write("[{0}]", n);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("union:");
            foreach (int n in unionList)
            {
                Console.Write("[{0}]", n);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("intersect:");
            foreach (int n in intersectList)
            {
                Console.Write("[{0}]", n);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("except:");
            foreach (int n in exceptList)
            {
                Console.Write("[{0}]", n);
            }
            Console.WriteLine("\n\n");

            Console.ReadLine();
        }
    }
}
