namespace VisitorPattern.DynamicVisitor
{
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            Value = value;
        }
    }
}
