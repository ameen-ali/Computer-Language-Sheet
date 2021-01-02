using System;

/*
   Write a method ReadNumber(int start, int end)
   that reads an integer from the console in the range [start…end].
   In case the input integer is not valid or it is not in 
   the required range throw appropriate exception. Using this method,
   write a program that takes 10 integers a1, a2, …, 
   a10 such that 1 < a1 < … < a10 < 100.
*/

namespace Application36
{
    class Program
    {
        static void ReadNumber(int start, int end)
        {
            int count = 1;
            int number;

            do
            {
                Console.Write("Number{0} : ", count);
                number = int.Parse(Console.ReadLine());

                if (number >= end || number <= start) {
                    Console.WriteLine("Wrong input!");
                    break;
                } else {
                    start = number;
                }

                count++;
            } while (count < 11);
        }

        static void Main(string[] args)
        {
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());

            if (end <= start + 10) {
                Console.WriteLine("Wrong input");
            } else {
                ReadNumber(start, end);
            }
        }
    }
}
