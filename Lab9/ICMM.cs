using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    interface ICMM
    {
        public void setCoffeeType(String str);
        public void setGrindingTime(int secs);
        public void addCondiment(ICondiment type);
        public void setTemperature(int degree);
        public void setLEDNumber(int num);
        public void computePrice(ICoffee cif);
        public void done();
    }
}
