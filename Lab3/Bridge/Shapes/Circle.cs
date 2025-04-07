using Bridge.RenderEngines;

namespace Bridge.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(IRenderEngine renderEngine, int radius)
            : base(renderEngine)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw()
        {
            renderEngine.RenderCircle(Radius);
        }
    }
}
