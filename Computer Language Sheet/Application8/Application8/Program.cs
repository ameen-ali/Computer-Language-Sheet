using System;

/* 
   write a method that returns the english 
   name of the last digit of a given number, 
   Example: for 512 print "two"; for 1024 prints "four".
*/

namespace Application8
{
    class Program
    {
        static string GetNameOFLastDigit(int number)
        {
            int LastDigit = number % 10;

            if (LastDigit == 1) {
                return "one";
            } else if (LastDigit == 2) {
                return "two";
            } else if (LastDigit == 3) {
                return "three";
            } else if (LastDigit == 4) {
                return "four";
            } else if (LastDigit == 5) {
                return "five";
            } else if (LastDigit == 6) {
                return "six";
            } else if (LastDigit == 7) {
                return "seven";
            } else if (LastDigit == 8) {
                return "eight";
            } else if (LastDigit == 9) {
                return "nine";
            } else {
                return "zero";
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please, enter the number : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetNameOFLastDigit(n));
        }
    }
}
