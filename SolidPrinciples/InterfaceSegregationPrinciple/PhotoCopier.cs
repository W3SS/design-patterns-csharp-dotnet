using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            //...
        }

        public void Scan(Document d)
        {
            //...
        }
    }
}
