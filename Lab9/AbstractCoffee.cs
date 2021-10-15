using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    abstract class AbstractCoffee : ICoffee
    {
        private ICMM icmm;

        public void setICMM(ICMM icmm)
        {
            this.icmm = icmm;
        }

        public ICMM getICMM()
        {
            return this.icmm;
        }

        public void run()
        {

        }

        public abstract double getPrice();
    }
}
