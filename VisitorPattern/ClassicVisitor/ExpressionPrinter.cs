﻿using System.Text;

namespace VisitorPattern.ClassicVisitor
{
    public class ExpressionPrinter : IExpressionVisitor
    {
        StringBuilder sb = new StringBuilder();

        public void Visit(DoubleExpression de)
        {
            sb.Append(de.Value);
        }

        public void Visit(AdditionExpression ae)
        {
            sb.Append("(");

            ae.Left.Accept(this);

            sb.Append("+");

            ae.Right.Accept(this);

            sb.Append(")");
        }

        public override string ToString() => sb.ToString();
    }
}
