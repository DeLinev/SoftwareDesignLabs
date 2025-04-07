using Composite;
using System.Text;

namespace Flyweight
{
    public class FlyweightElementNode : LightNode
    {
        private LightElementNode _sharedElement;
        public List<LightNode> Children { get; set; }

        public FlyweightElementNode(LightElementNode sharedElement)
        {
            _sharedElement = sharedElement;
            Children = new List<LightNode>();
        }

        public void AddChild(LightNode node)
        {
            if (_sharedElement.IsSelfClosing)
                return;

            Children.Add(node);
        }


        public override string InnerHtml()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children)
            {
                sb.Append(child.OuterHtml());
            }
            return sb.ToString();
        }

        public override string OuterHtml()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<").Append(_sharedElement.TagName);

            if (_sharedElement.IsSelfClosing)
            {
                sb.Append(" />");
            }
            else
            {
                sb.Append(">");
                sb.Append(InnerHtml());
                sb.Append("</").Append(_sharedElement.TagName).Append(">");
            }

            return sb.ToString();
        }

        public override int ChildElementsCount()
        {
            int count = 0;

            foreach (var child in Children)
            {
                if (child is LightElementNode)
                {
                    count += 1 + child.ChildElementsCount();
                }
            }

            return count;
        }
    }
}
