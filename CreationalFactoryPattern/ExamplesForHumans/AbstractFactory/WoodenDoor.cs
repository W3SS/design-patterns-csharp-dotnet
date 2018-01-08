using System;

namespace FactoryPattern.ExamplesForHumans.AbstractFactory
{
    public class WoodenDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door");
        }
    }
}
