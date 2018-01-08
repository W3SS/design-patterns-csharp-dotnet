using System;

namespace FactoryPattern.ExamplesForHumans.AbstractFactory
{
    public class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit iron doors");
        }
    }
}
