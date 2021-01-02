using System;

/*
   create a method GetMax() with two integer (int) parameter,
   that returns maximal of two numbers. write a program that
   read three numbers from console and print the biggest of them.
   use the GetMax() method you just created. write a test program that
   validates that the method works correctly. 
*/

namespace Application7
{
    class Program
    {
        static int GetMax(int number1, int number2)
        {
            if (number1 > number2) {
                return number1;
            } else {
                return number2;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 3 : ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Max Number : {0}", Math.Max(GetMax(x, y), z));
        }
    }
}
