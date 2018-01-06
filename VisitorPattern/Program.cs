using System;
using System.Text;
using VisitorPattern.DynamicVisitor;
//using VisitorPattern.ClassicVisitor;
//using VisitorPattern.IntrusiveExpressionPrinting;
//using VisitorPattern.ReflectionBasedPrinting;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new AdditionExpression(
                left: new DoubleExpression(1),
                right: new AdditionExpression(
                    left: new DoubleExpression(2),
                    right: new DoubleExpression(3)
                )
            );

            // INTRUSIVE EXPRESSION PRINTING - NOT VISITOR PATTERN

            //var sb = new StringBuilder();

            //e.Print(sb);

            //Console.WriteLine(sb);

            // what is more likely: new type or new operation

            // REFLECTION BASED PRINTING - STILL NOT USING VISITOR PATTERN

            //var sb = new StringBuilder();

            //ExpressionPrinter.Print2(e, sb);
            //Console.WriteLine(sb);

            // CLASSIC VISITOR

            //var ep = new ExpressionPrinter();
            //ep.Visit(e);

            //Console.WriteLine(ep.ToString());

            //var calc = new ExpressionCalculator();
            //calc.Visit(e);

            //Console.WriteLine($"{ep} = {calc.Result}");

            // DYNAMIC VISITOR

            var ep = new ExpressionPrinter();
            var sb = new StringBuilder();

            ep.Print((dynamic)e, sb);

            Console.WriteLine(sb);

            // disadvantages:

            // 1) Performance penalty
            // 2) Runtime error on missing visitor
            // 3) Problematic w.r.t. inheritance

            Console.ReadLine();
        }
    }
}
