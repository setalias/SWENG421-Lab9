using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Regular: AbstractCoffee
    {
        double price = 2;

        public override double getPrice()
        {
            return this.price;
        }

        public void run()
        {

        }
    }
}
