﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Cappucino : AbstractCoffee
    {
        double price = 3;

        public double getPrice(double price)
        {
            return this.price;
        }

        public void run()
        {

        }
    }
}
