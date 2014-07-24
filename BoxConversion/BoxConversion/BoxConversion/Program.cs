using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxConversion
{
    internal struct PointStruct
    {
        public int x;
        public int y;

        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class PointClass
    {
        public int x;
        public int y;
        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            //See the difference between struct and class

            PointStruct p = new PointStruct(2, 4);
            object box = p;
            p.x = 200;
            Console.WriteLine("PointStruct p.x={0}", p.x);
            Console.WriteLine("Box Box.x={0}", ((PointStruct)box).x);

            Console.WriteLine();

            PointClass p1 = new PointClass(2, 4);
            object box1 = p1;
            p1.x = 200;
            Console.WriteLine("PointClass p1.x={0}", p1.x);
            Console.WriteLine("Box Box.x={0}", ((PointClass)box1).x);

            Console.ReadLine();
        }
    }
}
