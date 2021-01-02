using System;
using System.IO;

/*
   Write a program that reads a text file and prints
   its odd lines on the console.
*/

namespace Application45
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Text Files\File.txt";

            Console.WriteLine("The Odd Line In The Text File Is...\n");
            StreamReader reader = new StreamReader(path);
            int lineCount = 1;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (lineCount++ % 2 != 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
