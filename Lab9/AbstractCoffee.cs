

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

        public abstract void run();

        public abstract double getPrice();
    }
}
