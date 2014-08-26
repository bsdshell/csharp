using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryDecompositionPow
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteNum = 0;
            int recNum = 0;
            int count = 10000000;

            for (int i = 0; i < count; i++)
            {
                iteNum = BinaryDecompositionIteration(7, 10);
            }
            Console.WriteLine("Iteration={0}", iteNum);

            for (int i = 0; i < count; i++)
            {
                recNum = BinaryDecompositionRecursion(7, 10);
            }
            Console.WriteLine("Recursion={0}", recNum);

            Console.ReadLine();
        }
        static int BinaryDecompositionRecursion(int x, int y)
        {
            if (y == 0)
                return 1;
            else if (y % 2 == 0)
            {
                return BinaryDecompositionRecursion(x, y/2) * BinaryDecompositionRecursion(x, y/2);
            }
            else
            {
                return x * BinaryDecompositionRecursion(x, y/2) * BinaryDecompositionRecursion(x, y/2);
            }
        }

        static int BinaryDecompositionIteration(int x, int y)
        {
            int ret = 1;
            while (true)
            {
                if ((y & 1) != 0)
                    ret = x * ret;
                y = y >> 1;
                if (y == 0)
                    return ret;
                x *= x;
            }
        }
    }
    
}
