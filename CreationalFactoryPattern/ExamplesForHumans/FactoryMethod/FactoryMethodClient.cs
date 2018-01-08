using System;

namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    public class FactoryMethodClient
    {
        static void Demo()
        {
            var devManager = new DevelopmentManager();

            devManager.TakeInterview(); // Output: Asking about design patterns

            var marketingManager = new MarketingManager();

            marketingManager.TakeInterview(); // Output: Asking about community building.

            Console.ReadLine();
        }
    }
}
