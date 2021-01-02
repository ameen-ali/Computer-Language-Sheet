using System;

/* 
   Write a method that prints the digits
   of a given decimal number in a reversed order.
   For example 256, must be printed as 652. 
*/

namespace Application12
{
    class Program
    {
        public static int Reverse(int number)
        {
            int reverse = 0, rem;
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }
            return reverse;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter The number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Reverse(number));
        }
    }
}
