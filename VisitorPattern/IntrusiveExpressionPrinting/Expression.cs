using System.Text;

namespace VisitorPattern.IntrusiveExpressionPrinting
{
    public abstract class Expression
    {
        // adding a new operation
        public abstract void Print(StringBuilder sb);
    }
}
