using Bridge.RenderEngines;
using Bridge.Shapes;

class Program
{
    static void Main(string[] args)
    {
        IRenderEngine rasterEngine = new RasterEngine();
        IRenderEngine vectorEngine = new VectorEngine();

        Shape[] shapes =
        {
            new Circle(rasterEngine, 5),
            new Circle(vectorEngine, 7),
            new Square(rasterEngine, 10),
            new Square(vectorEngine, 15),
            new Triangle(rasterEngine, 3, 4, 5),
            new Triangle(vectorEngine, 6, 8, 10)
        };

        Console.WriteLine("Drawing shapes...");
        Console.WriteLine("------------------------------------");
        foreach (var shape in shapes)
        {
            shape.Draw();
            Console.WriteLine($"The area of the {nameof(shape)} is {shape.CalculateArea()}");
            Console.WriteLine("------------------------------------");
        }
    }
}