using System;
using System.Text.RegularExpressions;

namespace PositiveIntegerRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array =
            {
                "123",
                "+123",
                "0",
                "0013"
            };
            string pattern = @"^[1-9]\d*$|^[+][1-9]\d*$";
            Regex regex = new Regex(pattern, RegexOptions.Compiled);
            foreach (string input in array)
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine("{0} = {1}", input, match.Success);
                }
            }
            Console.ReadLine();
        }
    }
}
