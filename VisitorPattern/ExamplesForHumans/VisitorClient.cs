using System;

namespace VisitorPattern.ExamplesForHumans
{
    public class VisitorClient
    {
        public static void Demo()
        {
            var monkey = new Monkey();
            var lion = new Lion();
            var dolphin = new Dolphin();

            var speak = new Speak();

            monkey.Accept(speak);    // Ooh oo aa aa!    

            lion.Accept(speak);      // Roaaar!

            dolphin.Accept(speak);   // Tuut tutt tuutt!

            // Another operation

            var jump = new Jump();

            monkey.Accept(jump);    // Jumped 20 feet high! on to the tree!

            lion.Accept(jump);      // Jumped 7 feet! Back on the ground!

            dolphin.Accept(jump);   // Walked on water a little and disappeared

            Console.ReadLine();
        }
    }
}
