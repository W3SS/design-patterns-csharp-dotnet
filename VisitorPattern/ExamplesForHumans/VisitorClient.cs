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

            Console.ReadLine();
        }
    }
}
