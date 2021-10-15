using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    abstract class AbstractOther : AbstractCoffee
    {
        double price = 5;

        public double getPrice(double price)
        {
            return this.price;
        }

        public void run()
        {

        }
    }
}
