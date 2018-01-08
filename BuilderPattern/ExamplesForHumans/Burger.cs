namespace BuilderPattern.ExamplesForHumans
{
    public class Burger
    {
        protected int size;

        protected bool cheese = false;
        protected bool pepperoni = false;
        protected bool lettuce = false;
        protected bool tomato = false;

        public Burger(BurgerBuilder builder)
        {
            this.size = builder.Size;
            this.cheese = builder.Cheese;
            this.pepperoni = builder.Pepperoni;
            this.lettuce = builder.Lettuce;
            this.tomato = builder.Tomato;
        }
    }
}
