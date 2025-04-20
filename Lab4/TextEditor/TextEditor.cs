using Memento;

public class TextEditor
{
    private TextDocument textDocument;
    private Stack<TextDocument.TextDocumentMemento> history = new();

    public TextEditor(string initialText)
    {
        textDocument = new TextDocument(initialText);
    }

    public void Backup()
    {
        history.Push(textDocument.Save());
    }

    public void Undo()
    {
        if (history.Count > 0)
        {
            textDocument.Restore(history.Pop());
        }
    }

    public void WriteLine(string text)
    {
        Backup();
        textDocument.AppendText("\n" + text);
    }

    public void Write(string text)
    {
        Backup();
        textDocument.AppendText(text);
    }

    public string GetContent()
    {
        return textDocument.GetText();
    }


}
