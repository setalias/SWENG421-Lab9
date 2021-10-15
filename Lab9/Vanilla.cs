using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Vanilla : AbstractCondiment
    {
        private static double price = 0.5;

        public Vanilla() : base(null, price) {}
        public Vanilla(ICoffee coffee) : base(coffee, price) {}
    }
}
