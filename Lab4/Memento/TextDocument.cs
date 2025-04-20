namespace Memento
{
    public class TextDocument
    {
        private string text;

        public TextDocument(string text)
        {
            this.text = text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public string GetText()
        {
            return text;
        }

        public void AppendText(string text)
        {
            this.text += text;
        }

        public TextDocumentMemento Save()
        {
            return new TextDocumentMemento(text);
        }

        public void Restore(TextDocumentMemento memento)
        {
            text = memento.GetState();
        }

        public class TextDocumentMemento
        {
            private string text;

            internal TextDocumentMemento(string text)
            {
                this.text = text;
            }

            internal string GetState()
            {
                return text;
            }
        }
    }
}
