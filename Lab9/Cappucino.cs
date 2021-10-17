
namespace Lab9
{
    class Cappucino : AbstractCoffee
    {
        private double price = 3;

        public override double getPrice()
        {
            return this.price;
        }

        public override void run()
        {
            this.getICMM().setLEDNumber(12);
        }
    }
}
