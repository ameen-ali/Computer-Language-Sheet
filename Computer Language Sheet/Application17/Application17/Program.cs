using System;

/* 
   Write a program to simulate n nested loops from 1 to n.
*/

namespace Application17
{
    class Program
    {
        static void Loops(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (int element in arr)
                {
                    Console.Write("{0} ", element);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Loops(arr, index + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("enter n : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Loops(arr, 0);
        }
    }
}
