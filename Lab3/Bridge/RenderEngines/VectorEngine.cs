namespace Bridge.RenderEngines
{
    public class VectorEngine : IRenderEngine
    {
        public void RenderCircle(int radius)
        {
            Console.WriteLine($"Drawing a circle with radius {radius} as a vector graphic.");
        }

        public void RenderSquare(int side)
        {
            Console.WriteLine($"Drawing a square with side {side} as a vector graphic.");
        }

        public void RenderTriangle(int a, int b, int c)
        {
            Console.WriteLine($"Drawing a triangle with sides {a}, {b}, {c} as a vector graphic.");
        }
    }
}
