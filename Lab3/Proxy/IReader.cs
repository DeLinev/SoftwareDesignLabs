namespace Proxy
{
    public interface IReader
    {
        char[][] ReadFile(string filePath);
        void DisplayByLetters(char[][] content);
    }
}
