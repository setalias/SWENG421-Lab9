using System;

namespace Lab9
{
    interface ICMM
    {
        public void setCoffeeType(String str);
        public void setGrindingTime(int secs);
        public void addCondiment(ICondiment type);
        public void setTemperature(int degree);
        public void setLEDNumber(int num);
        public void computePrice();
        public void done();
    }
}
