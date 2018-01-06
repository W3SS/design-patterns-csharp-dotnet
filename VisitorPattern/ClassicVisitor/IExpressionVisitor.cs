namespace VisitorPattern.ClassicVisitor
{
    public interface IExpressionVisitor
    {
        void Visit(DoubleExpression de);
        void Visit(AdditionExpression ae);
    }
}
