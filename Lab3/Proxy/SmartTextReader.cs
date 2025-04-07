namespace Proxy
{
    public class SmartTextReader : IReader
    {

        public char[][] ReadFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                char[][] chars = new char[lines.Length][];

                for (int i = 0; i < lines.Length; i++)
                {
                    chars[i] = lines[i].ToCharArray();
                }

                return chars;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured while reading a file: {ex.Message}");
                return [];
            }
        }
        public void DisplayByLetters(char[][] content)
        {
            foreach (var line in content)
            {
                Console.WriteLine(string.Join('|', line));
            }
        }
    }
}
