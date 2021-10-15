using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    abstract class AbstractCondiment: ICondiment
    {
        protected ICoffee coffee;

        protected AbstractCondiment(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public abstract double getPrice();

        public abstract ICoffee addToCoffee();
    }
}
