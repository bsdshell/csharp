using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foreach
{
    class Program
    {
        //Condition in foreach
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "dog", "cat", "cow", "tocoma narrows", "geoduck", "apple", "computer" };

            string str = list.Count > 0 ? list[0] : string.Empty;
            foreach (var item in list.Skip(1))
            {
                str += string.Format("{0}{1}", "|", item);
            }
            Console.WriteLine("str = [{0}]", str);

            //Iterate through second element and the length of string is greater than 3
            foreach (var item in list.Where((x, index) => index > 0 && x.Length > 3))
            {
                Console.WriteLine("[{0}]", item);
            }

            //Element and Index
            foreach (var item in list.Where((x, index) => index % 2 == 0))
            {
                Console.WriteLine("str = [{0}]", item);
            }
            Console.WriteLine();
            
            //Take
            foreach (var item in list.Take(3))
            {
                Console.WriteLine("str = [{0}]", item);
            }

            Console.ReadLine();
        }
    }
}
