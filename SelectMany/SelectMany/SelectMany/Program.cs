using System;
using System.Collections.Generic;
using System.Linq;
namespace SelectMany
{
    class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<string> listFood;

        public person() { }
        public person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>() { "tortoise", "geoduck", "falcon" };
            List<int> number = new List<int>() { 1, 2, 3, 4 };
            List<int> prime = new List<int>() { 11, 13, 17 };

            List<person> listPerson = new List<person>
            {
                new person
                {
                    firstName = "Tomy", 
                    lastName  = "Lee",
                    listFood =  new List<string>
                    {
                        "apple",
                        "orange",
                        "banana"
                    }
                },
                new person
                {
                    firstName = "Jet", 
                    lastName  = "Lee",
                    listFood =  new List<string>
                    {
                        "GreenCherry",
                        "BlackBerry",
                        "BlueBerry"
                    }
                }
            };

            //SelectMany
            var animalList = animals.SelectMany(a => number, (a, n) => new { a, n });
            foreach (var v in animalList)
            {
                Console.WriteLine("({0} {1})", v.a, v.n);
            }

            Console.WriteLine();
            //Compound from 
            var cartesianProduct = from num in number
                                   from pri in prime
                                   where pri > num
                                   select new { num, pri };

            foreach (var v in cartesianProduct)
            {
                Console.WriteLine("Cartesian Product:({0} {1})", v.num, v.pri);
            }
            Console.WriteLine();

            //Select
            var mylist = from p in listPerson select p.firstName;
            foreach (var v in mylist)
            {
                Console.WriteLine("({0})", v);
            }
            Console.WriteLine();

            //Select Where
            mylist = from p in listPerson where p.lastName.Equals("last") select p.firstName;
            foreach (var v in mylist)
            {
                Console.WriteLine("({0})", v);
            }

            var listList = listPerson.Select(p => p.listFood);
            Console.WriteLine("Select: Generate a list of list");
            foreach (var list in listList)
            {
                foreach (var str in list)
                {
                    Console.WriteLine("({0})", str);
                }
                Console.WriteLine();
            }

            var flattenList = listPerson.SelectMany(p => p.listFood);
            Console.WriteLine("SelectMany : Flatten the list");
            foreach (var str in flattenList)
            {
                Console.WriteLine("({0})", str);
            }
            Console.ReadLine();
        }
    }
}
