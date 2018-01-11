using System;

namespace VisitorPattern.ExamplesForHumans
{
    public class Lion : IAnimal
    {
        public void Roar()
        {
            Console.WriteLine("Roaaar!");
        }

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitLion(this);
        }
    }
}
