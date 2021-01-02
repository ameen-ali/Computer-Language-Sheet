using System;

/*
   Write a program that calculates and prints 
   the n! for any n in the range [1…100].
*/

namespace Application15
{
    class Program
    {
        static double Factorial(double number)
        {
            if (number <= 1) {
                return 1;
            } else {
                return number * Factorial(number - 1);
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("{0}! = {1}", i, Factorial(i));
            }
        }
    }
}
