using System;
using System.Text;

/* 
   write a program that reads a string from the console 
   (20 charcture maximum) and if shorter completements
   it right with "*" to 20 charcture.
*/

namespace Application5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Text : ");
            string Text = Console.ReadLine();

            StringBuilder text = new StringBuilder();
            int maxSize = 20;

            for (int i = 0; i < maxSize; i++)
            {
                if (i < Text.Length)
                {
                    text.Append(Text[i]);
                }
                else
                {
                    text.Append('*');
                }
            }
            Console.WriteLine(text.ToString());
        }
    }
}
