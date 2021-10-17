
namespace Lab9
{
    class Regular: AbstractCoffee
    {
        private double price = 2;

        public override double getPrice()
        {
            return this.price;
        }

        public override void run()
        {
            this.getICMM().setLEDNumber(10);
        }

        
    }
}
