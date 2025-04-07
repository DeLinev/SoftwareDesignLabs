namespace Proxy
{
    public class SmartTextChecker : IReader
    {
        private IReader _reader;

        public SmartTextChecker(IReader reader)
        {
            _reader = reader;
        }


        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");
            char[][] result = _reader.ReadFile(filePath);

            if (result.Length > 0)
            {
                Console.WriteLine("File was successfully read.");
                Console.WriteLine($"Total lines: {result.Length}");
                Console.WriteLine($"Total characters: {result.Sum(line => line.Length)}");
            }

            Console.WriteLine("File was closed.");

            return result;
        }
        public void DisplayByLetters(char[][] content)
        {
            _reader.DisplayByLetters(content);
        }
    }
}
