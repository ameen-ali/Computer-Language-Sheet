using System;

/*
   Write a program, which prints, on the console 
   which day of the week is today.
*/

namespace Application23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter year : ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("enter month : ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("enter day : ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine();
            DateTime dateValue = new DateTime(year, month, day);
            Console.WriteLine(dateValue.ToString("dddddddd"));
        }
    }
}
