namespace DecoratorPattern.ExamplesForHumans
{
    public class SimpleCoffee : ICoffee
    {
        public int GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "Simple coffee";
        }
    }
}
