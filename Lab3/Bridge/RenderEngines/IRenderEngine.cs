namespace Bridge.RenderEngines
{
    public interface IRenderEngine
    {
        void RenderCircle(int radius);
        void RenderSquare(int side);
        void RenderTriangle(int a, int b, int c);
    }
}
