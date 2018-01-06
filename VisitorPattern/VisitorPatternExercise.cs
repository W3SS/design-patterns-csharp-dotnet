using System.Text;

namespace VisitorPattern.Exercise
{
    // You are asked to implement a double-dispatch visitor called ExpressionPrinter  
    // for printing different mathematical expressions.
    // The range of expressions covers addition and multiplication. 
    // Please put round brackets after around addition operations (but not multiplication ones)! 
    // Also, please avoid any blank spaces in output.

    // Example:

    // Input: AdditionExpression(Literal(2), Literal(3)) 
    // Output: (2+3) 
    // Here is the corresponding unit test:

    // [Test]
    // public void SimpleAddition()
    // {
    //    var simple = new AdditionExpression(new Value(2), new Value(3));
    //    var ep = new ExpressionPrinter();
    //    ep.Accept(simple);
    //    Assert.That(ep.ToString(), Is.EqualTo("(2+3)"));
    // }

    public abstract class ExpressionVisitor
    {
        public abstract void Accept(Value value);
        public abstract void Accept(AdditionExpression ae);
        public abstract void Accept(MultiplicationExpression me);
    }

    public abstract class Expression
    {
        public abstract void Visit(ExpressionVisitor ev);
    }

    public class Value : Expression
    {
        public readonly int TheValue;

        public Value(int value)
        {
            TheValue = value;
        }

        public override void Visit(ExpressionVisitor ev)
        {
            ev.Accept(this);
        }
    }

    public class AdditionExpression : Expression
    {
        public readonly Expression LHS, RHS;

        public AdditionExpression(Expression lhs, Expression rhs)
        {
            LHS = lhs;
            RHS = rhs;
        }

        public override void Visit(ExpressionVisitor ev)
        {
            ev.Accept(this);
        }
    }

    public class MultiplicationExpression : Expression
    {
        public readonly Expression LHS, RHS;

        public MultiplicationExpression(Expression lhs, Expression rhs)
        {
            LHS = lhs;
            RHS = rhs;
        }

        public override void Visit(ExpressionVisitor ev)
        {
            ev.Accept(this);
        }
    }

    public class ExpressionPrinter : ExpressionVisitor
    {
        private StringBuilder sb = new StringBuilder();

        public override void Accept(Value value)
        {
            sb.Append(value.TheValue);
        }

        public override void Accept(AdditionExpression ae)
        {
            sb.Append("(");

            ae.LHS.Visit(this);

            sb.Append("+");

            ae.RHS.Visit(this);

            sb.Append(")");
        }

        public override void Accept(MultiplicationExpression me)
        {
            me.LHS.Visit(this);

            sb.Append("*");

            me.RHS.Visit(this);
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }

    class VisitorPatternExercise
    {
    }
}
