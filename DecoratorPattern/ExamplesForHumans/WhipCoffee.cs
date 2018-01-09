namespace DecoratorPattern.ExamplesForHumans
{
    public class WhipCoffee : ICoffee
    {
        protected ICoffee coffee;

        public WhipCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public int GetCost()
        {
            return this.coffee.GetCost() + 5;
        }

        public string GetDescription()
        {
            return this.coffee.GetDescription() + ", whip";
        }
    }
}
