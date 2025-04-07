using Bridge.RenderEngines;

namespace Bridge.Shapes
{
    public abstract class Shape
    {
        protected IRenderEngine renderEngine;

        public Shape(IRenderEngine renderEngine)
        {
            this.renderEngine = renderEngine;
        }

        public abstract double CalculateArea();
        public abstract void Draw();
    }
}
