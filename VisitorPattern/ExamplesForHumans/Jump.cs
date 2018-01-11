using System;

namespace VisitorPattern.ExamplesForHumans
{
    public class Jump : IAnimalOperation
    {
        public void VisitMonkey(Monkey monkey)
        {
            Console.WriteLine("Jumped 20 feet high! on to the tree!");
        }

        public void VisitLion(Lion lion)
        {
            Console.WriteLine("Jumped 7 feet! Back on the ground!");
        }

        public void VisitDolphin(Dolphin dolphin)
        {
            Console.WriteLine("Walked on water a little and disappeared");
        }
    }
}
