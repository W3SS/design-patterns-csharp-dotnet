using System;

namespace MediatorPattern.ExamplesForHumans
{
    public class MediatorClient
    {
        public static void Demo()
        {
            var mediator = new ChatRoom();

            var john = new User("John Doe", mediator);
            var jane = new User("Jane Doe", mediator);

            john.Send("Hi there!");
            jane.Send("Hey!");

            // Output will be
            // Feb 14, 10:58 [John]: Hi there!
            // Feb 14, 10:58 [Jane]: Hey!

            Console.ReadLine();
        }
    }
}
