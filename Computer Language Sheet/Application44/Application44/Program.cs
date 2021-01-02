using System;

namespace Application44
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone mb = new MobilePhone();
            mb.model = null;
            mb.manufacturer = null;
            mb.price = 0.0m;
            mb.owner = null;

            Console.WriteLine(FeaturesOfTheBattery.model);
            Console.WriteLine(FeaturesOfTheBattery.idle);
            Console.WriteLine(FeaturesOfTheBattery.time);
            Console.WriteLine(FeaturesOfTheBattery.hourstalk);

            Console.WriteLine(FeaturesOfTheScreen.colors);
            Console.WriteLine(FeaturesOfTheScreen.size);
        }
    }
}
