using System;

/*
   write a program that detect how many times
   a substring is contained in the text.
*/

namespace Application3
{
    class Program
    {
        static int CountString(string text, string keyword)
        {
            int Count = 0;
            int i = 0;

            text = text.ToLower();
            while ((i = text.IndexOf(keyword, i)) != -1)
            {
                i += keyword.Length;
                Count++;
            }
            return Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Text : ");
            string text = Console.ReadLine();

            Console.WriteLine("Enter The Keyword : ");
            string Keyword = Console.ReadLine();

            Console.WriteLine("\n" + CountString(text, Keyword));
        }
    }
}
