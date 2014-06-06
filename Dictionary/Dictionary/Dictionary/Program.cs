using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("k1", "cow");
            dict.Add("k2", "dog");
            dict.Add("k3", "cat");
            for (int i = 0; i < dict.Count; i++)
            {
                KeyValuePair<string, string> entiry = dict.ElementAt(i);
                Console.WriteLine("key=" + entiry.Key + " Value=" + entiry.Value);
            }
            Console.WriteLine("=================================================");
            foreach (KeyValuePair<string, string> entiry in dict)
            {
                Console.WriteLine("key=" + entiry.Key + " Value=" + entiry.Value);
            }
            Console.ReadLine();
        }
    }
}
