using System;

namespace FactoryPattern.ExamplesForHumans.AbstractFactory
{
    public class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit wooden doors");
        }
    }
}
