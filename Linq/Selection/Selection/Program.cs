using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[]{1, 2, 4, 7, 9};

            var source = number.Select(ele => new Num {num = ele*10}).ToList();
            foreach (var s in source)
            {
                System.Console.WriteLine("s={0}", s.num);
            }
            System.Console.ReadLine();
        }
    }

    public class Num
    {
        public int num;
        public Num()
        {}
    }
}
