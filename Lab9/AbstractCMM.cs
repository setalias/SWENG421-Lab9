using System.Collections.Generic;

namespace Lab9
{
    abstract class AbstractCMM : ICMM
    {
        protected AbstractCoffee coffeeMaker;
        protected ICoffee coffeeCup;
        protected List<ICoffee> cupSales;

        public abstract void addCondiment(ICondiment type);
        public abstract void computePrice();
        public abstract void done();
        public abstract void setCoffeeType(string str);
        public abstract void setGrindingTime(int secs);
        public abstract void setLEDNumber(int num);
        public abstract void setTemperature(int degree);
    }
}
