using System;

/*
   Write a program to generate all variations 
   with duplicates of n elements class k. Sample input:

   n = 3
   k = 2 

  Sample output :
  (1 1), (1 2), (1 3), (2 1), (2 2), (2 3), (3 1), (3 2), (3 3)
*/

namespace Application18
{
    class Program
    {
        static void GetCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length - 1) {
                        Console.Write("{0} ", arr[i]);
                    } else {
                        Console.Write(arr[i]);
                    }
                }
                Console.Write("), ");
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GetCombinations(arr, index + 1, i, end);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("enter n : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("enter k : ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[k];

            Console.WriteLine();
            GetCombinations(arr, 0, 1, n);
        }
    }
}
