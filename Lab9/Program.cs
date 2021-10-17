using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            ICMM coffeemaker = new CMM();
            coffeemaker.setCoffeeType("Mocha");
            coffeemaker.computePrice();

            Console.WriteLine("\n");

            ICMM coffeeMaker = new CMM();
            coffeeMaker.setCoffeeType("Espresso");
            coffeeMaker.computePrice();
        }
    }
}
