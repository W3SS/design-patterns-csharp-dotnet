namespace SolidPrinciples.InterfaceSegregationPrinciple.Interfaces
{
    public interface IMachine
    {
        void Print(Document d);
        void Fax(Document d);
        void Scan(Document d);
    }
}
