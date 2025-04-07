using Bridge.RenderEngines;

namespace Bridge.Shapes
{
    public class Square : Shape
    {
        public int Side { get; set; }

        public Square(IRenderEngine renderEngine, int side) : base(renderEngine)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override void Draw()
        {
            renderEngine.RenderSquare(Side);
        }
    }
}
