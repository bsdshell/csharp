using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace SplitLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Rest assured that the PS4 journey has just begun, and we'll continue the " +
                                 "momentum this holiday season with blockbuster titles, including Destiny, Driveclub, " +
                                 "Grand Theft Auto V, inFAMOUS First Light, " +
                                 "Little Big Planet 3, and NBA 2K15, and innovative titles " +
                                 "including Grim Fandango, Hotline Miami 2: Wrong Number and Minecraft";

            string str = SplitLine(inputString, 10);
            Console.WriteLine(str);
            Console.ReadLine();
        }

        /// <summary>
        /// Replace all whitespaces with space, and split numWords # words to a line
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="numWords"></param>
        /// <returns></returns>
        static string SplitLine(string inputString, int numWords)
        {
            string returnString = string.Empty;
            if (!string.IsNullOrEmpty(inputString))
            {
                string[] delimiter = new string[]{@" "};
                inputString = Regex.Replace(inputString, @"\s+", @" ").Trim();
                List<string> words = inputString.Split(delimiter, StringSplitOptions.None).ToList();
                List<string> lineList = new List<string>();

                string line = string.Empty;
                for(int i = 0; i<words.Count; i++)
                {
                    if (i % numWords == 0)
                    {
                        if (!string.IsNullOrEmpty(line.Trim()))
                        {
                            lineList.Add(line);
                        }
                        line = string.Empty;
                        line += words[i].Trim() + @" ";
                    }
                    else
                    {
                        line += words[i].Trim() + @" ";
                    }
                }
                returnString = lineList.Aggregate(returnString, (current, t) => current + (t + Environment.NewLine));
            }
            return returnString;
        }
    }
}
