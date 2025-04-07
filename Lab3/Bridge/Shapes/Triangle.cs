using Bridge.RenderEngines;

namespace Bridge.Shapes
{
    public class Triangle : Shape
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public Triangle(IRenderEngine renderEngine, int a, int b, int c) : base(renderEngine)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalculateArea()
        {
            int p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override void Draw()
        {
            renderEngine.RenderTriangle(A, B, C);
        }
    }
}
