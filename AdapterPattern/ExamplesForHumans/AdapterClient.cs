using System;

namespace AdapterPattern.ExamplesForHumans
{
    public class AdapterClient
    {
        static void Demo()
        {
            var wildDog = new WildDog();

            var wildDogAdapter = new WildDogAdapter(wildDog);

            var hunter = new Hunter();

            hunter.Hunt(wildDogAdapter);

            Console.ReadLine();
        }
    }
}
