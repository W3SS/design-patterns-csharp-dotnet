using System;
using System.Text;

namespace VisitorPattern.IntrusiveExpressionPrinting
{
    public class AdditionExpression : Expression
    {
        public Expression Left, Right;

        public AdditionExpression(Expression left, Expression right)
        {
            Left = left ?? throw new ArgumentNullException(paramName: nameof(left));
            Right = right ?? throw new ArgumentNullException(paramName: nameof(right));
        }

        public override void Print(StringBuilder sb)
        {
            sb.Append(value: "(");

            Left.Print(sb);

            sb.Append(value: "+");

            Right.Print(sb);

            sb.Append(value: ")");
        }
    }
}
