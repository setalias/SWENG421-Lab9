using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
