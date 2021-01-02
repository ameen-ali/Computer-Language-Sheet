using System;
using System.IO;

/*
  Write a program that reads the contents of a text file and
  inserts the line numbers at the beginning of each line,
  then rewrites the file contents.
*/

namespace Application47
{
    class Program
    {
        static void InsertLinesToResultFile(string pathText, string pathResult)
        {
            int lineCount = 1;
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream)
                    {
                        result.WriteLine("Line {0} : {1}", lineCount++, reader.ReadLine());
                    }
                }
            }
        }

        static void PrintResultContent(string path)
        {
            Console.WriteLine(" Result : \n");
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            Console.WriteLine("\n End of file...\n");
        }

        static void Main(string[] args)
        {
            string pathText = @"D:\Text Files\File.txt";
            string pathResult = @"D:\Text Files\Result.txt";

            InsertLinesToResultFile(pathText, pathResult);
            PrintResultContent(pathResult);
        }
    }
}
