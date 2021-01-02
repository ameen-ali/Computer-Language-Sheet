using System;

/* 
  25. Define your own namespace CreatingAndUsingObjects
      and place in it two classes Cat and Sequence, 
      which we used in the examples of the current chapter.
      Define one more namespace and make a class, 
      which calls the classes Cat and Sequence, in it.

  26. Write a program which creates 10 objects of type Cat,
      gives them names CatN, where N is a unique serial number of the object,
      and in the end call the method SayMiau() for each of them.
      For the implementation use the namespace CreatingAndUsingObjects. 
*/

namespace Application25
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Cat";
            for (int i = 0; i < 10; i++)
            {
                Cat cat = new Cat(name + Sequence.NextValue());
                cat.sayMiau();
            }
            Console.ReadLine();
        }
    }
}
