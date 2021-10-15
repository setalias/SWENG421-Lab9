using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Mocha : AbstractCoffee
    {
        private double price = 4;

        public override double getPrice()
        {
            return this.price;
        }

        public override void run()
        {
            this.getICMM().setGrindingTime(8);
            this.getICMM().setTemperature(150);
        }
    }
}
