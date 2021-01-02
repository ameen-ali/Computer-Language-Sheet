using System;

/* 
   Write a recursive program,
   which prints all subsets of a given set of N words.
   Example input:
   words = {'test', 'rock', 'fun'}
  
   Example output:
   (), (test), (rock), (fun), (test rock), (test fun),
   (rock fun), (test rock fun)

   Think about and implement an iterative algorithm for the same task.
*/

namespace Application20
{
    class Program
    {
        static string[] strings, str;
        static int length;

        static void cycle(int iter, int index, int k)
        {
            if (iter == k)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine("({0})", str[i]);
                }
                return;
            }

            for (int i = index; i < strings.Length; i++)
            {
                str[iter] = strings[i];
                cycle(iter + 1, i + 1, k);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("enter words length: ");
            length = int.Parse(Console.ReadLine());

            strings = new string[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("enter {0} word: ", i + 1);
                strings[i] = Console.ReadLine();
            }

            for (int i = 0; i <= length; i++)
            {
                str = new string[length];
                cycle(0, 0, i);
            }
        }
    }
}
