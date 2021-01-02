using System;

/*
   Write a method that finds the biggest element of an array,
   Use that method to implement sorting in descending order. 
*/

namespace Application14
{
    class Program
    {
        public static int GetMax(int[] array, int start, int end)
        {
            int max = array[start];
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array length : ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter start index : ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter end index : ");
            int endIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBiggest number in interval {0}-{1} is {2}.",
                startIndex, endIndex, GetMax(arr, startIndex, endIndex));
        }
    }
}
