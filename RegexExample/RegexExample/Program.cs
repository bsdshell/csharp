using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace RegexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = @" numbers = ""num1"" dog=""dogvalue""   text     =""textvalue"" ";
            Regex regex = new Regex("(numbers)\\s*=\\s*\"(.*?)\"\\s+.*?(text)\\s*=\\s*\"(.*?)\"");
            MatchCollection match = regex.Matches(inputStr);

            string xmlStr = @"<book  size  =  ""big"" color  = ""   red"" />";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlStr);
            XmlElement root = doc.DocumentElement;

            if (root.HasAttribute("color"))
            {
                string value = root.GetAttribute("color");
                Console.WriteLine("color=[{0}]", value);
            }
            if (root.HasAttribute("size"))
            {
                string value = root.GetAttribute("size");
                Console.WriteLine("size=[{0}]", value);
            }

            System.Console.ReadLine();

            if (match.Count > 0)
            {
                foreach(Match m in match)
                {
                    foreach (Group g in m.Groups)
                    {
                        System.Console.WriteLine("Group[{0}]={1}", g.Index, g.Value);
                    }
                }
            }

            System.Console.ReadLine();
        }
    }
}
