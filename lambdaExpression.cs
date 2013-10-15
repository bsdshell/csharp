using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//lamda expression
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> { 1, 2, 3 };
            var evens = number.FindAll(n => n % 2 == 0);


            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            var shortDigits = digits.Where((digit) => digit.Length > 2);
            System.Console.WriteLine("line=========");
            foreach (var sd in shortDigits)
            {
                Console.WriteLine(sd);
            }

            System.Console.WriteLine("line=========");
            System.Console.Read();
        }
    }
}