using System;

/*
   Write a method that finds how many times certain number 
   can be found in a given array. Write a program to test 
   that the method works correctly. 
*/

namespace Application9
{
    class Program
    {
        public static int HowManyElemenetFound(int[] arr, int element)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Array Length : ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            Console.WriteLine("Enter The Elements Of Array : ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter The Element Which You Search It  : ");
            int elem = int.Parse(Console.ReadLine());

            Console.WriteLine(" The number {0} is repeated in the matrix {1} times ", elem, HowManyElemenetFound(arr, elem));
        }
    }
}
