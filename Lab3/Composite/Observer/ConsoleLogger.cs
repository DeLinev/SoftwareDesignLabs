namespace Composite.Observer
{
    public class ConsoleLogger : IEventListener
    {
        public ConsoleColor Color { get; set; }

        public ConsoleLogger(ConsoleColor color)
        {
            Color = color;
        }

        public void Update(object sender, string eventName)
        {
            Console.ForegroundColor = Color;
            if (sender is LightElementNode elementNode)
            {
                Console.WriteLine($"Event '{eventName}' occurred in {elementNode.TagName} element.");
                Console.WriteLine($"Element: {elementNode.OuterHtml()}");
            }
            else
            {
                Console.WriteLine($"Event '{eventName}' occurred in {sender.GetType().Name}.");
            }
            Console.ResetColor();
        }
    }
}
