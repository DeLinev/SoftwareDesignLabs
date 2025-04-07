using Composite;

namespace Flyweight
{
    public class LightHtmlDocument
    {
        private LightElementFactory _factory;

        public LightNode RootNode { get; set; }
        public LightNode Body { get; set; }

        public LightHtmlDocument()
        {
            _factory = new LightElementFactory();
            RootNode = new LightElementNode("html");

            LightElementNode head = new LightElementNode("head");
            LightElementNode body = new LightElementNode("body");

            ((LightElementNode)RootNode).AddChild(head);
            ((LightElementNode)RootNode).AddChild(body);

            Body = body;
        }

        public string GetHTML()
        {
            return "<!DOCTYPE html>\n" + RootNode.OuterHtml();
        }

        public void LinesToHtml(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                LightElementNode element;

                if (i == 0)
                {
                    element = new LightElementNode("h1");
                }
                else if (line.Length < 20)
                {
                    element = new LightElementNode("h2");
                }
                else if (line.StartsWith(" ") || line.StartsWith("\t"))
                {
                    element = new LightElementNode("blockquote");
                }
                else
                {
                    element = new LightElementNode("p");
                }

                element.AddChild(new LightTextNode(line));
                ((LightElementNode)Body).AddChild(element);
            }
        }

        public void LinesToHtmlWithFlyweight(string[] lines)
        {
            LightElementNode h1Shared = _factory.GetElement("h1");
            LightElementNode h2Shared = _factory.GetElement("h2");
            LightElementNode blockquoteShared = _factory.GetElement("blockquote");
            LightElementNode pShared = _factory.GetElement("p");

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                FlyweightElementNode element;

                if (i == 0)
                {
                    element = new FlyweightElementNode(h1Shared);
                }
                else if (line.Length < 20)
                {
                    element = new FlyweightElementNode(h2Shared);
                }
                else if (line.StartsWith(" ") || line.StartsWith("\t"))
                {
                    element = new FlyweightElementNode(blockquoteShared);
                }
                else
                {
                    element = new FlyweightElementNode(pShared);
                }

                element.AddChild(new LightTextNode(line));
                ((LightElementNode)Body).AddChild(element);
            }
        }
    }
}
