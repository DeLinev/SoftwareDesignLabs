using System.Xml.Linq;

namespace Composite.Visitor
{
    public class CountVisitor : INodeVisitor
    {
        public int ElementNodeCount { get; private set; }
        public int TextNodeCount { get; private set; }
        public int NodesCount {
            get {
                return ElementNodeCount + TextNodeCount;
            }
        }
        public Dictionary<string, int> TagCount { get; private set; }

        public CountVisitor()
        {
            ElementNodeCount = 0;
            TextNodeCount = 0;
            TagCount = new Dictionary<string, int>();
        }

        public void Visit(LightElementNode node)
        {
            ElementNodeCount++;

            if (TagCount.ContainsKey(node.TagName))
            {
                TagCount[node.TagName]++;
            }
            else
            {
                TagCount[node.TagName] = 1;
            }
        }

        public void Visit(LightTextNode node)
        {
            TextNodeCount++;
        }
    }
}
