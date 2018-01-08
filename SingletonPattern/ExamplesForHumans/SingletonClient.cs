using System;

namespace SingletonPattern.ExamplesForHumans
{
    public class SingletonClient
    {
        static void Demo()
        {
            var president1 = President.GetInstance();
            var president2 = President.GetInstance();

            Console.WriteLine(president1 == president2); // true
            
            Console.ReadLine();
        }
    }
}
