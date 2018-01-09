using System;

namespace ProxyPattern.ExamplesForHumans
{
    public class LabDoor : IDoor
    {
        public void Open()
        {
            Console.WriteLine("Opening lab door");
        }

        public void Close()
        {
            Console.WriteLine("Closing the lab door");
        }
    }
}
