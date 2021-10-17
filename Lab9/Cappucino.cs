using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Cappucino : AbstractCoffee
    {
        private double price = 3;

        public override double getPrice()
        {
            return this.price;
        }

        public override void run()
        {
            this.getICMM().setLEDNumber(12);
        }
    }
}
