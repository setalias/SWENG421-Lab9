using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    abstract class AbstractOther : AbstractCoffee
    {
        private double price = 5;

        public override double getPrice()
        {
            return this.price;
        }

    }
}
