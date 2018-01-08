namespace FactoryPattern.ExamplesForHumans.SimpleFactory
{
    public class WoodenDoor : IDoor
    {
        protected float Width;
        protected float Height;

        public WoodenDoor(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public float GetHeight()
        {
            return this.Height;
        }

        public float GetWidth()
        {
            return this.Width;
        }
    }
}
