using Composite;
using Composite.Observer;

class Program
{
    static void Main()
    {
        LightElementNode root = new LightElementNode("div");
        root.AddCssClass("container", "main");
        LightElementNode h1 = new LightElementNode("h1");
        h1.AddCssClass("title");
        h1.AddChild(new LightTextNode("Hello World!"));
        root.AddChild(h1);

        ConsoleLogger consoleLogger = new ConsoleLogger(ConsoleColor.Cyan);
        FileLogger fileLogger = new FileLogger(@"../../../log.txt");

        root.EventManager.Subscribe("click", consoleLogger);
        root.EventManager.Subscribe("click", fileLogger);
        root.EventManager.Subscribe("mouseover", consoleLogger);

        root.TriggerEvent("click");
        root.TriggerEvent("mouseover");
    }
}