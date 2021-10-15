using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Cream : AbstractCondiment
    {
        public Cream(ICoffee coffee) : base(coffee) {}

        public override ICoffee addToCoffee()
        {
            return this;
        }

        public override double getPrice()
        {
            return this.coffee.getPrice() + 0.25;
        }
    }
}
