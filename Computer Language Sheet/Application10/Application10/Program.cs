using System;

/*
   Write a method that checks whether an element,
   from a certain position in an array is greater than its two neighbors.
   Test whether the method works correctly.
*/

namespace Application10
{
    class Program
    {
        static void CompareNumber(int position, int[] array)
        {
            if (position == 0)
            {
                if (array[0] < array[1]) {
                    Console.WriteLine("{0} is smaller than it's right.", array[0]);
                } else if (array[0] > array[1]) {
                    Console.WriteLine("{0} is bigger than it's right.", array[0]);
                } else {
                    Console.WriteLine("{0} is equal to it's right.", array[0]);
                }
            }

            else if (position == array.Length - 1)
            {
                if (array[array.Length - 1] < array[array.Length - 2]) {
                    Console.WriteLine("{0} is smaller than it's left.", array[position]);
                } else if (array[array.Length - 1] > array[array.Length - 2]) {
                    Console.WriteLine("{0} is bigger than it's left.", array[position]);
                } else {
                    Console.WriteLine("{0} is equal to it's left.", array[position]);
                }
            }
            else
            {
                if (array[position] < array[position - 1])
                {
                    if (array[position] < array[position + 1]) {
                        Console.WriteLine("{0} is smaller than it's neighbours.", array[position]);
                    } else if (array[position] == array[position + 1]) {
                        Console.WriteLine("{0} is smaller than it's left and equal to it's right.", array[position]);
                    } else {
                        Console.WriteLine("{0} is smaller than it's left and bigger than it's right.", array[position]);
                    }
                }
                else if (array[position] == array[position - 1])
                {
                    if (array[position] < array[position + 1]) {
                        Console.WriteLine("{0} is euqal to it's left and smaller than it's right.", array[position]);
                    } else if (array[position] == array[position + 1]) {
                        Console.WriteLine("{0} is equal to it's neighbours.", array[position]);
                    } else {
                        Console.WriteLine("{0} is equal to it's left and bigger than it's right.", array[position]);
                    }
                }
                else
                {
                    if (array[position] < array[position + 1]) {
                        Console.WriteLine("{0} is bigger than it's left and smaller than it's right.", array[position]);
                    } else if (array[position] == array[position + 1]) {
                        Console.WriteLine("{0} is bigger than it's left and equal to it's right.", array[position]);
                    } else {
                        Console.WriteLine("{0} is bigger than it's neighbours.", array[position]);
                    }
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

            Console.Write("Enter position in array : ");
            int p = int.Parse(Console.ReadLine());
            CompareNumber(p, arr);
        }
    }
}