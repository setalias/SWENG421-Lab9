using System;

namespace Lab9
{
    interface ICMM
    {
        void setCoffeeType(String str);
        void setGrindingTime(int secs);
        void addCondiment(ICondiment type);
        void setTemperature(int degree);
        void setLEDNumber(int num);
        void computePrice();
        void done();
    }
}
