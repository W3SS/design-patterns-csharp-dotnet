namespace FactoryPattern.ExamplesForHumans.SimpleFactory
{
    public class WoodenDoor : IDoor
    {
        protected float width;
        protected float height;

        public WoodenDoor(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float GetHeight()
        {
            return this.height;
        }

        public float GetWidth()
        {
            return this.width;
        }
    }
}
