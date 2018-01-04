using DecoratorPattern.AdapterDecorator;
using DecoratorPattern.DynamicDecoratorComposition;
using System;

namespace DecoratorPattern
{
    class Program
    {
        // CRTP cannot be done
        //public class ColoredShape2<T> : T where T : Shape { }

        public class ColoredShape<T> : Shape where T : Shape, new()
        {
            private string color;
            private T shape = new T();

            public ColoredShape() : this("black")
            {

            }

            public ColoredShape(string color) // no constructor forwarding
            {
                this.color = color ?? throw new ArgumentNullException(paramName: nameof(color));
            }

            public override string AsString()
            {
                return $"{shape.AsString()} has the color {color}";
            }
        }

        public class TransparentShape<T> : Shape where T : Shape, new()
        {
            private float transparency;
            private T shape = new T();

            public TransparentShape(float transparency)
            {
                this.transparency = transparency;
            }

            public override string AsString()
            {
                return $"{shape.AsString()} has transparency {transparency * 100.0f}";
            }
        }

        static void Main(string[] args)
        {
            // SIMPLE DECORATOR ON SEALED CLASS
            var cb = new CodeBuilder();

            cb.AppendLine("class Foo")
              .AppendLine("{")
              .AppendLine("}");

            Console.WriteLine(cb);

            // ADAPTER DECORATOR
            MyStringBuilder s = "hello ";
            s += "world"; // will work even without op+ in MyStringBuilder
                          // why? you figure it out!

            Console.WriteLine(s);

            // DYNAMIC DECORATOR COMPOSITION
            var square = new Square(1.23f);
            Console.WriteLine(square.AsString());

            var redSquare = new ColoredShape(square, "red");
            Console.WriteLine(redSquare.AsString());

            var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTransparentSquare.AsString());

            // static
            ColoredShape<Circle> blueCircle = new ColoredShape<Circle>("blue");
            Console.WriteLine(blueCircle.AsString());

            TransparentShape<ColoredShape<Square>> blackHalfSquare = new TransparentShape<ColoredShape<Square>>(0.4f);
            Console.WriteLine(blackHalfSquare.AsString());

            Console.ReadLine();
        }
    }
}
