using System;

/*
   Write a program that takes a positive integer 
   from the console and prints the square root of this integer.
   If the input is negative or invalid print "Invalid Number"
   in the console. In all cases print "Good Bye".
*/

namespace Application35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string text = Console.ReadLine();

            int n = -1;
            bool invalidNumber = false;

            try
            {
                n = int.Parse(text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
                invalidNumber = true;
            }
            finally
            {
                if (n < 0)
                {
                    if (!invalidNumber)
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(n));
                }
            }
            Console.WriteLine("Good Bye");
        }
    }
}
