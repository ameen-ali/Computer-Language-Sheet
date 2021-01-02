using System;

/* 
   A text is given. Write a program that modifies 
   the casing of letters to uppercase at all places 
   in the text surrounded by <upcase> and </upcase> tags.
   Tags cannot be 
*/

namespace Application4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the text : ");
            string text = Console.ReadLine();

            char[] textNew = new char[text.Length];
            int i = 0, j = 0, k = 0;

            while (i < text.Length)
            {
                if (text.IndexOf("<upcase>", k) < 0)
                {
                    while (i < text.Length)
                    {
                        textNew[j++] = text[i++];
                    }
                }
                else
                {
                    while (i < text.IndexOf("<upcase>", k))
                    {
                        textNew[j++] = text[i++];
                    }

                    i += 8;
                    k = i;
                }

                if (text.IndexOf("</upcase>", k) < 0)
                {
                    while (i < text.Length)
                    {
                        textNew[j++] = char.ToUpper(text[i++]);
                    }
                }
                else
                {
                    while (i < text.IndexOf("</upcase>", k))
                    {
                        textNew[j++] = char.ToUpper(text[i++]);
                    }
                    i += 9;
                }
            }

            Console.WriteLine();
            foreach (char c in textNew)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
