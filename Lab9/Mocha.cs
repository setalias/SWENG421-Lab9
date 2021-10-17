
namespace Lab9
{
    class Mocha : AbstractCoffee
    {
        private double price = 4;

        public override double getPrice()
        {
            return this.price;
        }

        public override void run()
        {
            this.getICMM().setLEDNumber(11);
            this.getICMM().setGrindingTime(8);
            this.getICMM().setTemperature(150);
            this.getICMM().setLEDNumber(0);

        }
    }
}
