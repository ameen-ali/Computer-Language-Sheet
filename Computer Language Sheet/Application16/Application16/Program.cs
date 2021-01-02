using System;

/* 
   Write a program that solves the following tasks:
    - Put the digits from an integer number into a reversed order.
    - Calculate the average of given sequence of numbers.
    - Solve the linear equation a * x + b = 0. 
*/

namespace Application16
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Reverse()
        {
            int numberReverse;
            string stringNumberReverse;
            do
            {
                Console.Clear();
                Console.Write("Enter a non-negative number : ");
                stringNumberReverse = Console.ReadLine();
                numberReverse = int.Parse(stringNumberReverse);
            } while (numberReverse < 0);

            Console.WriteLine(" The number is inverted : " + ReverseString(stringNumberReverse));
            Console.ReadLine();
        }

        static void Average()
        {
            int numberAverage = 0;
            int entries = -1;
            int temp;
            string numberAverageString;
            bool input;

            Console.Clear();
            do
            {
                Console.Write("Enter a number from the row. Enter a letter to complete : ");
                numberAverageString = Console.ReadLine();
                input = int.TryParse(numberAverageString, out temp);
                numberAverage += temp;
                entries++;
            } while (input);

            Console.WriteLine("The arithmetic mean is {0}.", (float)numberAverage / entries);
        }

        static void SolveEquation()
        {
            int a = 0;
            do
            {
                Console.Clear();
                Console.Write("Enter a : ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            Console.Write("Enter b : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", (float)-b / a);
        }

        static void Main(string[] args)
        {
            byte choice;
            do
            {
                Console.Clear();

                Console.WriteLine("\n 1. Put the digits from an integer number into a reversed order.");
                Console.WriteLine("2. Calculate the average of given sequence of numbers.");
                Console.WriteLine("3. Solve the linear equation a * x + b = 0.");
                Console.WriteLine("4. Exit.");
                Console.Write("Enter a selection: ");

                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Reverse();
                        break;
                    case 2:
                        Average();
                        break;
                    case 3:
                        SolveEquation();
                        break;
                }

            } while (choice != 4);
            Console.WriteLine("\n The end ");
        }
    }
}
