
namespace Lab9
{
    abstract class AbstractCondiment: ICondiment
    {
        protected ICoffee coffee;
        private double price;

        protected AbstractCondiment(ICoffee coffee, double price)
        {
            this.coffee = coffee;
            this.price = price;
        }

        public double getPrice()
        {
            if (this.coffee != null)
            {
                return this.coffee.getPrice() + this.price;
            }
            else
            {
                return this.price;
            }
        }

        public ICoffee addToCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
            return this;
        }
    }
}
