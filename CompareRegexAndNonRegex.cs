using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           List<char> charList = new List<char>();
            for(int i=0; i< 'z'-'a' + 1; i++)
            {
                char ch = (char)('a' + i);
                charList.Add(ch);
            }

            for (int i = 0; i < 'z'-'a' + 1; i++)
            {
                char ch = (char)('A' + i);
                charList.Add(ch);
            }

            for (int i = 0; i < 10; i++)
            {
                char ch = (char)('0' + i);
                charList.Add(ch);
            }
            charList.Add(' ');
            charList.Add('_');
            charList.Add('#');
            
            Random random = new Random();
            List<string> strList = new List<string>();
            for (int i = 0; i < 10000000; i++)
            {
                string str = "";
                for (int j = 0; j < 10; j++)
                {
                    int randomNum = random.Next(0, charList.Count);
                    str += charList[randomNum].ToString();
                }
                strList.Add(str);
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Debug.WriteLine("Naive Way: Using IsLetterOrDigit() Stop Watch Start...");
            int validCount = 0;
            for (int i = 0; i < strList.Count; i++)
            {
                Boolean valid = true; 
                foreach(char ch in strList[i])
                {
                    if (!char.IsLetterOrDigit(ch) && ch != '_' && ch != ' ')
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    validCount++;
                }
            }


            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Debug.WriteLine("End Naive Way: Using IsLetterOrDigit() : # of Str=[{0}], size of Str=[{1}], valid Str=[{2}], Elapsed Time=[{3}]", strList.Count, 10, validCount, elapsedTime);

            Debug.WriteLine("");


            Stopwatch newWatch = new Stopwatch();
            newWatch.Start();
            Debug.WriteLine("Regular Exp: Stop Watch Start...");
            Regex invalidCharactersRecoStateRegex = new Regex(@"[^A-Za-z0-9_ ]");
            validCount = 0;
            for (int i = 0; i < strList.Count; i++)
            {
                Match match = invalidCharactersRecoStateRegex.Match(strList[i]);
                if (match.Success)
                {
                }
                else
                {
                    validCount++;                    
                }
            }
            ts = newWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Debug.WriteLine("End Regular Exp: # of Str=[{0}], string size=[{1}], valid Str=[{2}],Elapsed Time=[{3}]", strList.Count, 10, validCount, elapsedTime);
            Console.ReadLine();
            
        }
    }
}
