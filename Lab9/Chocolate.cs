using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Chocolate: AbstractCondiment
    {
        private static double price = 1.0;

        public Chocolate() : base(null, price) {}
        public Chocolate(ICoffee coffee) : base(coffee, price) {}
    }
}
