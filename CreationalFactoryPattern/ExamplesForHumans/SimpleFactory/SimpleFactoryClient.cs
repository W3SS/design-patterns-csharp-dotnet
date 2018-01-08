using System;

namespace FactoryPattern.ExamplesForHumans.SimpleFactory
{
    public class SimpleFactoryClient
    {
        static void Demo()
        {
            var door = DoorFactory.MakeDoor(100, 200);

            Console.WriteLine($"Width: {door.GetWidth()}");
            Console.WriteLine($"Height: {door.GetHeight()}");

            Console.ReadLine();
        }
    }
}
