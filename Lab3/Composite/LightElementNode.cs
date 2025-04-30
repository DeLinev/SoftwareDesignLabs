using Composite.Iterator;
using System.Text;

namespace Composite
{
    public class LightElementNode : LightNode, ITree
    {
        public string TagName { get; set; }
        public bool IsBlock { get; set; }
        public bool IsSelfClosing { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, bool isBlock = true, bool isSelfClosing = false)
        {
            TagName = tagName;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
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

        public void AddCssClass(params string[] cssClass)
        {
            foreach (var css in cssClass)
            {
                CssClasses.Add(css);
            }
        }

        public void AddChild(LightNode child)
        {
            if (IsSelfClosing)
                return;

            Children.Add(child);
        }

        public void RemoveChild(LightNode child)
        {
            Children.Remove(child);
        }

        public override string InnerHtml()
        {
            StringBuilder sb = new StringBuilder();
            foreach (LightNode child in Children)
            {
                sb.Append(child.OuterHtml());
            }
            return sb.ToString();
        }

        public override string OuterHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(OpeningTag());
            sb.Append(InnerHtml());
            sb.Append(ClosingTag());

            return sb.ToString();
        }

        protected string OpeningTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            sb.Append(TagName);
            if (CssClasses.Count > 0)
            {
                sb.Append(" class=\"");
                sb.AppendJoin("; ", CssClasses);
                sb.Append(";\"");
            }
            if (IsSelfClosing)
            {
                sb.Append(" />");
            }
            else
            {
                sb.Append(">");
            }
            return sb.ToString();
        }

        protected string ClosingTag()
        {
            StringBuilder sb = new StringBuilder();
            if (!IsSelfClosing)
            {
                sb.Append("</");
                sb.Append(TagName);
                sb.Append(">");
            }
            return sb.ToString();
        }

        public ITreeIterator CreateDeepthIterator()
        {
            return new DepthIterator(this);
        }

        public ITreeIterator CreateBreadthIterator()
        {
            return new BreadthIterator(this);
        }
    }
}
