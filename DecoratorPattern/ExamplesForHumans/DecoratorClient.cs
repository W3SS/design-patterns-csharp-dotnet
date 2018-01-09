using System;

namespace DecoratorPattern.ExamplesForHumans
{
    public class DecoratorClient
    {
        static void Demo()
        {
            var simpleCoffee = new SimpleCoffee();

            Console.WriteLine(simpleCoffee.GetCost()); // 10
            Console.WriteLine(simpleCoffee.GetDescription()); // Simple Coffee

            var milkCoffee = new MilkCoffee(simpleCoffee);

            Console.WriteLine(milkCoffee.GetCost()); // 12
            Console.WriteLine(milkCoffee.GetDescription()); // Simple Coffee, milk

            var whipCoffeWithMilk = new WhipCoffee(milkCoffee);

            Console.WriteLine(whipCoffeWithMilk.GetCost()); // 17
            Console.WriteLine(whipCoffeWithMilk.GetDescription()); // Simple Coffee, milk, whip

            var whipVanillaCoffeeWithMilk = new VanillaCoffee(whipCoffeWithMilk);

            Console.WriteLine(whipVanillaCoffeeWithMilk.GetCost()); // 20
            Console.WriteLine(whipVanillaCoffeeWithMilk.GetDescription()); // Simple Coffee, milk, whip, vanilla
            
            Console.ReadLine();
        }
    }
}
