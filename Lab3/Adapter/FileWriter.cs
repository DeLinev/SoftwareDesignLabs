namespace Adapter
{
    public class FileWriter
    {
        public string FilePath { get; set; }

        public FileWriter(string filePath)
        {
            FilePath = filePath;
        }

        public void Write(string message)
        {
            using (var writer = new StreamWriter(FilePath, true))
            {
                writer.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            using (var writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
