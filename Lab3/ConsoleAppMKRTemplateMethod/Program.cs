using Composite;

class Program
{
    static void Main()
    {
        var div = new LightElementNode("div");
        div.AddCssClass("container");

        var span = new LightElementNode("span", isBlock: false);
        span.AddChild(new LightTextNode("<Hello world>"));
        span.AddCssClass("text");

        div.AddChild(span);

        Console.WriteLine(div.Render());
    }
}