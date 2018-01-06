using System.Text;

namespace VisitorPattern.IntrusiveExpressionPrinting
{
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            Value = value;
        }

        public override void Print(StringBuilder sb)
        {
            sb.Append(Value);
        }
    }
}
