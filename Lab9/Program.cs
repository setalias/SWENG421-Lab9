using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            ICMM coffeeMaker = new CMM();
            coffeeMaker.setCoffeeType("Espresso");
            coffeeMaker.computePrice();
        }
    }
}
