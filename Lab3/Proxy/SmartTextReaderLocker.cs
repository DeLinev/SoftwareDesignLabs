using System.Text.RegularExpressions;

namespace Proxy
{
    public class SmartTextReaderLocker : IReader
    {
        private IReader _reader;

        public Regex RegEx { get; set; }

        public SmartTextReaderLocker(IReader reader, string regEx)
        {
            RegEx = new Regex(regEx);
            _reader = reader;
        }

        public char[][] ReadFile(string filePath)
        {
            if (RegEx.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return [];
            }

            return _reader.ReadFile(filePath);
        }

        public void DisplayByLetters(char[][] content)
        {
            _reader.DisplayByLetters(content);
        }
    }
}
