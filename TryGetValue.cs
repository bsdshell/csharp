using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryGetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("1", "cat");
            dictionary.Add("2", "cow");
            dictionary.Add("3", "cheetah");
            dictionary.Add("4", "chicken");
            dictionary.Add("5", "chimpanzee");

            string outString = null;
            if (dictionary.TryGetValue("7", out outString))
            {
                System.Console.WriteLine("[{}]", outString);
            }

            if (outString == null)
            {
                System.Console.WriteLine("outString == null", outString);
            }
            System.Console.ReadLine();

            //output: outString == null
        }
    }
}
