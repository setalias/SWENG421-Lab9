using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Cream : AbstractCondiment
    {
        private static double price = 0.25;

        public Cream() : base(null, price) {}
        public Cream(ICoffee coffee) : base(coffee, price) {}

    }
}
