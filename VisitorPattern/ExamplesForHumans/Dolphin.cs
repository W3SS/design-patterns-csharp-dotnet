using System;

namespace VisitorPattern.ExamplesForHumans
{
    public class Dolphin : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tuut tuttu tuutt!");
        }

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitDolphin(this);
        }
    }
}
