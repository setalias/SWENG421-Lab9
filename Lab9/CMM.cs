using System;

namespace Lab9
{
    class CMM : AbstractCMM
    {
        public override void setCoffeeType(String str)
        {
            Type type = Type.GetType("Lab9." + str, true);
            this.coffeeMaker = Activator.CreateInstance(type) as AbstractCoffee;
            coffeeMaker.setICMM(this);
            this.coffeeCup = this.coffeeMaker;
            coffeeMaker.run();
        }
        public override void setGrindingTime(int secs)
        {
            Console.WriteLine("Grind coffee beans for " + secs + " seconds.");
        }
        public override void addCondiment(ICondiment type)
        {
            this.coffeeCup = type.addToCoffee(this.coffeeCup);
        }
        public override void setTemperature(int degree)
        {
            Console.WriteLine("Heat the water to " + degree + " degrees.");
        }
        public override void setLEDNumber(int num)
        {
            // first digit 0 as idle 1 as running
            // second digit 0-regular 1-mocha 2-cappucino 3-other
            Console.WriteLine("LED Output: " + num);

        }
        public override void computePrice()
        {
            Console.WriteLine("Total price is $" + this.coffeeCup.getPrice());
        }
        public override void done()
        {
            this.cupSales.Add(this.coffeeCup);
            this.coffeeMaker = null;
            this.coffeeCup = null;
            this.setLEDNumber(0);
        }
    }
}
