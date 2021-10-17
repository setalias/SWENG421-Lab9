
namespace Lab9
{
    class Chocolate: AbstractCondiment
    {
        private static double price = 1.0;

        public Chocolate() : base(null, price) {}
        public Chocolate(ICoffee coffee) : base(coffee, price) {}
    }
}
