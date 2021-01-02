using System;

/* 
   You are given a sequence of positive integer numbers
   given as string of numbers separated by a space.
   Write a program, which calculates their sum. 
   Example: "43 68 9 23 318"  461. 
*/

namespace Application28
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.Write("Enter numbers: ");
            string inputNumbers = Console.ReadLine();

            string[] splitNumbers = inputNumbers.Split(' ');
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                result += int.Parse(splitNumbers[i]);
            }
            Console.WriteLine("Result is: {0}", result);
        }
    }
}
