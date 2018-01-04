using SolidPrinciples.DependencyInversionPrinciple;
using SolidPrinciples.LiskovSubstitutionPrinciple;
using SolidPrinciples.OpenClosedPrinciple;
using SolidPrinciples.SingleResponsibilityPrinciple;
using System.Diagnostics;
using static System.Console;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - SINGLE RESPONSIBILITY PRINCIPLE START

            //var j = new Journal();
            //j.AddEntry("I cried today.");
            //j.AddEntry("I ate a bug.");

            //WriteLine(j);

            //var p = new Persistence();
            //var filename = @"c:\temp\journal.txt";
            //p.SaveToFile(j, filename);

            //Process.Start(filename);

            // 1 - SINGLE RESPONSIBILITY PRINCIPLE END

            // 2 - OPEN CLOSED PRINCIPLE START

            //var apple = new Product("Apple", Color.Green, Size.Small);
            //var tree = new Product("Tree", Color.Green, Size.Large);
            //var house = new Product("House", Color.Blue, Size.Large);

            //Product[] products = { apple, tree, house };

            //var pf = new ProductFilter();
            //WriteLine("Green products (old):");
            //foreach (var p in pf.FilterByColor(products, Color.Green))
            //    WriteLine($" - {p.Name} is green");

            //// ^^ BEFORE

            //// vv AFTER
            //var bf = new BetterProductFilter();
            //WriteLine("Green products (new):");
            //foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            //    WriteLine($" - {p.Name} is green");

            //WriteLine("Large products");
            //foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
            //    WriteLine($" - {p.Name} is large");

            //WriteLine("Large blue items");
            //foreach (var p in bf.Filter(products,
            //  new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)))
            //)
            //{
            //    WriteLine($" - {p.Name} is big and blue");
            //}

            // 2 - OPEN CLOSED PRINCIPLE END

            // 3 - LISKOV SUBSTITUTION PRINCIPLE START

            //Rectangle rc = new Rectangle(2, 3);
            //WriteLine($"{rc} has area {Area(rc)}");

            //// should be able to substitute a base type for a subtype
            ///*Square*/
            //Rectangle sq = new Square();
            //sq.Width = 4;
            //WriteLine($"{sq} has area {Area(sq)}");

            // 3 - LISKOV SUBSTITUTION PRINCIPLE END

            // 4 - INTERFACE SEGREGATION PRINCIPLE START

            // Look inside the folder for example

            // 4 - INTERFACE SEGREGATION PRINCIPLE END

            // 5 - DEPENDENCY INVERSION PRINCIPLE START

            // hl modules should not depend on low-level; both should depend on abstractions
            // abstractions should not depend on details; details should depend on abstractions

            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Matt" };

            // low-level module
            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);

            // 5 - DEPENDENCY INVERSION PRINCIPLE END

            ReadLine();
        }

        static public int Area(Rectangle r) => r.Width * r.Height;
    }
}
