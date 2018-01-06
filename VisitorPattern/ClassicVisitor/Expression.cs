namespace VisitorPattern.ClassicVisitor
{
    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }
}
