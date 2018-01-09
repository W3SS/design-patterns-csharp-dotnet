namespace DecoratorPattern.ExamplesForHumans
{
    public class VanillaCoffee : ICoffee
    {
        protected ICoffee coffee;

        public VanillaCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public int GetCost()
        {
            return this.coffee.GetCost() + 3;
        }

        public string GetDescription()
        {
            return this.coffee.GetDescription() + ", vanilla";
        }
    }
}
