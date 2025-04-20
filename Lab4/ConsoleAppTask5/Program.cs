using System.Text;

class Program
{
    static void Main()
    {
        TextEditor textEditor = new TextEditor("Text Editor v0.0.1");
        StringBuilder textBuffer = new StringBuilder();
        ConsoleKeyInfo keyInfo;

        Console.WriteLine(textEditor.GetContent());
        Console.WriteLine("> Start typing. Press Enter to append text, Shift+Enter to add a new line, and Esc to exit.");

        while (true)
        {
            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
            else if (keyInfo.Key == ConsoleKey.Enter && keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
            {
                textEditor.WriteLine(textBuffer.ToString());
                UpdateConsole(textEditor.GetContent(), textBuffer);
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                textEditor.Write(textBuffer.ToString());
                UpdateConsole(textEditor.GetContent(), textBuffer);
            }
            else if (keyInfo.Key == ConsoleKey.Z && keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
            {
                textEditor.Undo();
                UpdateConsole(textEditor.GetContent(), textBuffer);
            }
            else if (keyInfo.Key == ConsoleKey.Backspace)
            {
                if (textBuffer.Length > 0)
                {
                    textBuffer.Remove(textBuffer.Length - 1, 1);
                    Console.Write("\b \b");
                }
            }
            else
            {
                textBuffer.Append(keyInfo.KeyChar);
                Console.Write(keyInfo.KeyChar);
            }
        }
    }

    static void UpdateConsole(string text, StringBuilder buffer)
    {
        buffer.Clear();
        Console.Clear();
        Console.WriteLine(text);
        Console.WriteLine("> Start typing. Press Enter to append text, Shift+Enter to add a new line, and Esc to exit.");
    }
}
