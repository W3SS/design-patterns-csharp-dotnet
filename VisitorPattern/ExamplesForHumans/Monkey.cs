using System;

namespace VisitorPattern.ExamplesForHumans
{
    public class Monkey : IAnimal
    {
        public void Shout()
        {
            Console.WriteLine("Ooh oo aa aa!");
        }

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitMonkey(this);
        }
    }
}
