using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace GenerateNormalizedFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"dir";


            if (File.Exists(filePath))
            {
                ProcessFile(filePath);
            }
            else if (Directory.Exists(filePath))
            {
                ProcessDirectory(filePath);
            }
            else
            {
                //Console.WriteLine("{0} is not valid file or directory", filePath);
            }
                        
            Console.ReadLine();
        }

        public static void ProcessDirectory(string dirName)
        {
            string[] fileEntires = Directory.GetFiles(dirName);
            foreach (string fileName in fileEntires)
            {
                ProcessFile(fileName);
            }

            string[] dirEntires = Directory.GetDirectories(dirName);
            foreach (string subDirName in dirEntires)
            {
                ProcessDirectory(subDirName);
            }
        }

        public static void ProcessFile(string filePath)
        {
            Console.WriteLine("filePath=[{0}]", filePath);
        }
    }
}
