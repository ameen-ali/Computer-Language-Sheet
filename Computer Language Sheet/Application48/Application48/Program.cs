using System;
using System.IO;

/*
  Write a program that compares two text files with 
  the same number of rows line by line and prints the number of 
  equal and the number of different lines.
*/

namespace Application48
{
    class Program
    {

        static int sameLinesCount = 0, diffLinesCount = 0;
        static void CompareTextFiles(string pathText1, string pathText2)
        {
            using (StreamReader reader1 = new StreamReader(pathText1))
            {
                using (StreamReader reader2 = new StreamReader(pathText2))
                {
                    while (!reader1.EndOfStream || !reader2.EndOfStream)
                    {
                        string line1 = reader1.ReadLine();
                        string line2 = reader2.ReadLine();

                        if (line1.CompareTo(line2) == 0) {
                            sameLinesCount++;
                        } else {
                            diffLinesCount++;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string pathText1 = @"D:\Text Files\file1.txt";
            string pathText2 = @"D:\Text Files\file2.txt";

            CompareTextFiles(pathText1, pathText2);

            Console.WriteLine("Same lines: {0}", sameLinesCount);
            Console.WriteLine("Different lines: {0}\n", diffLinesCount);
        }
    }
}
