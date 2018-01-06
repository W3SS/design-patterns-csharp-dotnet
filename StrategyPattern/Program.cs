using StrategyPattern.Dynamic;
using StrategyPattern.Static;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // DYNAMIC

            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "foo", "bar", "baz" });

            Console.WriteLine(tp);

            tp.Clear();

            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] { "foo", "bar", "baz" });

            Console.WriteLine(tp);

            // STATIC

            var tpstatic = new TextProcessorStatic<MarkdownListStrategy>();
            tpstatic.AppendList(new[] { "foo", "bar", "baz" });

            Console.WriteLine(tpstatic);

            var tpstatic2 = new TextProcessorStatic<HtmlListStrategy>();
            tpstatic2.AppendList(new[] { "foo", "bar", "baz" });

            Console.WriteLine(tpstatic2);

            Console.ReadLine();
        }
    }
}
