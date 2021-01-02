using System;

/*
   Write a method that calculates the sum of two very long 
   positive integer numbers. The numbers are represented as
   array digits and the last digit (the ones) is stored
   in the array at index 0. Make the method work for
   all numbers with length up to 10,000 digits. 
*/

namespace Application13
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int[] array1 = new int[10000];
            int[] array2 = new int[10000];

            Console.Write("Enter first number: ");
            string s1 = Console.ReadLine();

            length = s1.Length;
            for (int i = 0; i < s1.Length; i++)
            {
                array1[i] = int.Parse(s1.Substring(s1.Length - 1 - i, 1));
            }

            Console.Write("Enter second number: ");
            string s2 = Console.ReadLine();

            if (s2.Length > length)
            {
                length = s2.Length;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                array2[i] = int.Parse(s2.Substring(s2.Length - 1 - i, 1));
            }

            for (int i = 0; i < length; i++)
            {
                array1[i] += array2[i];
                if (array1[i] >= 10)
                {
                    array1[i] -= 10;
                    array1[i + 1]++;
                }
            }

            if (array1[length] == 1)
            {
                length++;
            }

            Console.WriteLine();
            Console.Write("Result is: ");

            for (int i = 0; i < length; i++)
            {
                Console.Write(array1[length - 1 - i]);
            }
        }
    }
}
