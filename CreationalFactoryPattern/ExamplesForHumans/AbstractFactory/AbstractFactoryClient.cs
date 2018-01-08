using System;

namespace FactoryPattern.ExamplesForHumans.AbstractFactory
{
    public class AbstractFactoryClient
    {
        static void Demo()
        {
            // Wooden Factory
            var woodenFactory = new WoodenDoorFactory();

            var door = woodenFactory.MakeDoor();
            var expert = woodenFactory.MakeFittingExpert();

            door.GetDescription();  // Output: I am a wooden door
            expert.GetDescription(); // Output: I can only fit wooden doors

            // Same for Iron Factory
            var ironFactory = new IronDoorFactory();

            var door2 = ironFactory.MakeDoor();
            var expert2 = ironFactory.MakeFittingExpert();

            door2.GetDescription();  // Output: I am an iron door
            expert2.GetDescription(); // Output: I can only fit iron doors

            Console.ReadLine();
        }
    }
}
