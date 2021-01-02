using System;

/* 
   Write a program, which generates and prints on 
   the console 10 random numbers in the range [100, 200]. 
*/

namespace Application22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.Next(100, 201));
            }
        }
    }
}
