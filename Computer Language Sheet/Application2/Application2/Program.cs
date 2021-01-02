using System;
using System.Text;

/* 
   write a program that reads a string. Reverse it and print it 
   to the console. for Example : "introduction" -> "noitcudortni".
*/

namespace Application2
{
    class Program
    {
        public static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter The Text : ");
            string text = Console.ReadLine();

            Console.WriteLine(ReverseText(text));
        }
    }
}
