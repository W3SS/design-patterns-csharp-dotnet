using BridgePattern.Interfaces;

namespace BridgePattern
{
    public abstract class Shape
    {
        protected IRenderer renderer;

        // a bridge between the shape that's being drawn and
        // the component that actually draws it
        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();

        public abstract void Resize(float factor);
    }
}
