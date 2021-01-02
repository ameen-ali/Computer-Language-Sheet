using System;

/* 
   write a program, which read from
   the console a year and check if it is a leap year.
*/

namespace Application21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Year : ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0) {
                if ((year % 100 == 0) && (year % 400 != 0)) {
                    Console.Write("{0} : is not a leap year", year);
                } else {
                    Console.Write("{0} : is a leap year", year);
                }
            } else {
                Console.Write("{0} : is not a leap year", year);
            }
        }
    }
}
