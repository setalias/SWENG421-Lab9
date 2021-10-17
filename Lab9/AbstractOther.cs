
namespace Lab9
{
    abstract class AbstractOther : AbstractCoffee
    {
        private double price = 5;

        public override double getPrice()
        {
            return this.price;
        }

    }
}
