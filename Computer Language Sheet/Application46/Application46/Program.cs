using System;
using System.IO;
using System.Linq;

namespace Application46
{
    class Program
    {
        static void ReadFileContent(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult, true))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream)
                    {
                        result.WriteLine(reader.ReadLine());
                    }
                }
            }
        }

        static void PrintResultContent(string path)
        {
            Console.WriteLine("Result : \n");

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }

            Console.WriteLine("\n End of file ...\n");
        }

        static void Main(string[] args)
        {
            string pathText1 = @"D:\Text Files\file1.txt";
            string pathText2 = @"D:\Text Files\file2.txt";
            string pathResult = @"D:\Text Files\Result.txt";

            ReadFileContent(pathText1, pathResult);
            ReadFileContent(pathText2, pathResult);

            PrintResultContent(pathResult);
        }
    }
}
