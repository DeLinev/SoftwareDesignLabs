namespace Composite.Observer
{
    public class FileLogger : IEventListener
    {
        public string FilePath { get; set; }

        public FileLogger(string filePath)
        {
            FilePath = filePath;
        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"[{DateTime.Now}]: {message}");
            }
        }

        public void Update(object sender, string eventType)
        {
            if (sender is LightElementNode elementNode)
            {
                Log($"Event '{eventType}' occurred in {elementNode.TagName} element.");
                Log($"Element: {elementNode.OuterHtml()}");
            }
            else
                Log($"Event '{eventType}' occurred in {sender.GetType().Name}.");
        }
    }
}
