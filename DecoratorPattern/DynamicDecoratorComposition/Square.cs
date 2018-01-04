namespace DecoratorPattern.DynamicDecoratorComposition
{
    public class Square : Shape
    {
        private float side;

        public Square() : this(0)
        {

        }

        public Square(float side)
        {
            this.side = side;
        }

        public override string AsString() => $"A square with side {side}";
    }
}
