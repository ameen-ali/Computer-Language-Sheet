using System;

/* 
   Write a method that returns the position of 
   the first occurrence of an element from an array,
   such that it is greater than its two neighbors simultaneously.
   Otherwise the result must be -1.
*/

namespace Application11
{
    class Program
    {
        static int number = int.MinValue;
        static void CompareNumber(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    number = array[i];
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array length : ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            CompareNumber(arr);

            if (number == int.MinValue) {
                Console.WriteLine("-1");
            } else {
                Console.WriteLine("{0} is bigger than it's neighbours", number);
            }
        }
    }
}
