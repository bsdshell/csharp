using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class RegularExpression
    {
        static void Main(string[] args)
        {
            String variant = @"<dog> <cat><abc> asdfasd <world> asdkjadf<< <what>";
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"<[^<>]*>");
            System.Text.RegularExpressions.MatchCollection matches = regex.Matches(variant);

            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                String matchName = (String)match.Groups.SyncRoot.ToString();
                String matchToken="";
                if (matchName.Length > 2)
                {
                     matchToken = matchName.Substring(1, matchName.Length - 2);
                }
                System.Console.WriteLine("matchName=" + matchName);
                System.Console.WriteLine("matchToken=" + matchToken);
            }
            System.Console.Read();
        }
    }
}
