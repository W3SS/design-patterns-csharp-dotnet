using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class ShapeExe
    {
        private IRendererExe rendering;

        protected ShapeExe(IRendererExe rendering)
        {
            this.rendering = rendering;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {Name} as {rendering.WhatToRenderAs}";
        }
    }

    public interface IRendererExe
    {
        string WhatToRenderAs { get; }
    }

    public class Triangle : ShapeExe
    {
        public Triangle(IRendererExe renderingStrategy) 
            : base(renderingStrategy)
        {
            Name = "Triangle";
        }
    }

    public class Square : ShapeExe
    {
        public Square(IRendererExe renderingStrategy) 
            : base(renderingStrategy)
        {
            Name = "Square";
        }
    }

    public class RasterRendererExe : IRendererExe
    {
        public string WhatToRenderAs
        {
            get { return "pixels"; }
        }
    }

    public class VectorRendererExe : IRendererExe
    {
        public string WhatToRenderAs
        {
            get { return "lines"; }
        }
    }

    public class VectorSquare : Square
    {
        public VectorSquare(IRendererExe renderingStrategy) 
            : base(renderingStrategy)
        {
        }

        public override string ToString() => $"Drawing {Name} as lines";
    }

    public class RasterSquare : Square
    {
        public RasterSquare(IRendererExe renderingStrategy) 
            : base(renderingStrategy)
        {
        }

        public override string ToString() => $"Drawing {Name} as pixels";
    }

    // imagine VectorTriangle and RasterTriangle are here too

    class BridgePatternExercise
    {
    }
}
