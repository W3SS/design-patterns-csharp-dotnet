using System;

namespace BuilderPattern.ExamplesForHumans
{
    public class BuilderClient
    {
        static void Demo()
        {
            var burger = (new BurgerBuilder(14))
                            .AddPepperoni()
                            .AddLettuce()
                            .AddTomato()
                            .Build();

            Console.ReadLine();
        }
    }
}
