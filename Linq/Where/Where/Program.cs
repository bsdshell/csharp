using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Where
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"cat", "dog", "cow", "human", "a", "d", "ab"};

            var newList = list.Where(e => e.Length > 1);
        }
    }
}
