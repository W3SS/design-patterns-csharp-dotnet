using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d)
        {
            // yep
        }

        public void Fax(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new System.NotImplementedException();
        }
    }
}
