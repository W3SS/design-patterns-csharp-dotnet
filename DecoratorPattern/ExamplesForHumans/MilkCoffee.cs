namespace DecoratorPattern.ExamplesForHumans
{
    class MilkCoffee : ICoffee
    {
        protected ICoffee coffee;

        public MilkCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public int GetCost()
        {
            return this.coffee.GetCost() + 2;
        }

        public string GetDescription()
        {
            return this.coffee.GetDescription() + ", milk";
        }
    }
}
