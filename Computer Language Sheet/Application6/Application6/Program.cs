using System;

/* 
   write a code that by given name 
   prints on the console "Hello, <name>!"
*/

namespace Application6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please, enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
