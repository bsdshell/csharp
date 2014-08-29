using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace OrderedDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary orderedDict = new OrderedDictionary();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                orderedDict.Add("key" + i, "value" + i);
                dict.Add("key" + i, "value" + i);
                if (i % 3 == 0)
                {
                    dict.Remove("key" + r.Next(dict.Count));
                    orderedDict.Remove("key" + r.Next(orderedDict.Count));
                }
            }

            Console.WriteLine("Ordered Dictionary");
            foreach (DictionaryEntry entry in orderedDict)
            {
                Console.WriteLine("{0}={1}", entry.Key, entry.Value);
            }
            Console.WriteLine("===================");
            Console.WriteLine("Normal Dictionary");
            foreach (KeyValuePair<string, string> entry in dict)
            {
                Console.WriteLine("{0}={1}", entry.Key, entry.Value);
            }
            Console.ReadLine();
        }
    }
}
