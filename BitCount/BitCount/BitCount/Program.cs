using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt32 n = 179;
            long count = countBit(n);
            System.Console.WriteLine("n={0}", count);
            System.Console.ReadLine();
        }

        static long countBit(long n)
        {
            UInt32 c;
            for (c = 0; n != 0; c++)
            {
                n &= n - 1;
            }
            return c;
        }
    }
}
