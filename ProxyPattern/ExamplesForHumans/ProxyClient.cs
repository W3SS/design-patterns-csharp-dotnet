using System;

namespace ProxyPattern.ExamplesForHumans
{
    public class ProxyClient
    {
        public static void Demo()
        {
            var door = new SecurityProxy(new LabDoor());

            door.Open("invalid"); // Big no! It ain't possible.

            door.Open("$ecr@t"); // Opening lab door

            door.Close(); // Closing lab door

            Console.ReadLine();
        }
    }
}
