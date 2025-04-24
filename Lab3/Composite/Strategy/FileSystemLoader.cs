namespace Composite.Strategy
{
    public class FileSystemLoader : IImageLoader
    {
        public string LoadImage(string href)
        {
            if (File.Exists(href))
            {
                return $"Image was loaded from file system: {href}";
            }

            return $"Error: File {href} was not found";
        }
    }
}
