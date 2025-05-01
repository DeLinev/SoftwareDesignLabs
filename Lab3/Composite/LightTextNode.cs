using Composite.Visitor;

namespace Composite
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string OuterHtml()
        {
            return Text;
        }

        public override string InnerHtml()
        {
            return Text;
        }

        public override string RenderOuterHtml()
        {
            return Text;
        }

        public override string RenderInnerHtml()
        {
            return Text;
        }

        public override int ChildElementsCount()
        {
            return 0;
        }

        protected override void OnCreated()
        {
            Console.WriteLine($"Created light text node.");
        }

        protected override void OnRendered()
        {
            Console.WriteLine($"Text node rendered: {Text}.");
        }

        protected override void OnTextSanitize()
        {
            Text = Text.Replace("<", "&lt;").Replace(">", "&gt;");
        }

        public override void Accept(INodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
