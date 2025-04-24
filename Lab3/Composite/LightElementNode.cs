using System.Text;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public bool IsBlock { get; set; }
        public bool IsSelfClosing { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        public LightElementNode(string tagName, bool isBlock = true, bool isSelfClosing = false)
        {
            TagName = tagName;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            Attributes = new Dictionary<string, string>();
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

        public void SetAttribute(string name, string value)
        {
            Attributes[name] = value;
        }

        public void RemoveAttribute(string name)
        {
            if (Attributes.ContainsKey(name))
            {
                Attributes.Remove(name);
            }
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
            sb.Append("<");
            sb.Append(TagName);

            if (CssClasses.Count > 0)
            {
                sb.Append(" class=\"");
                sb.AppendJoin("; ", CssClasses);
                sb.Append(";\"");
            }

            foreach (var attribute in Attributes)
            {
                sb.Append(" ");
                sb.Append(attribute.Key);
                sb.Append("=\"");
                sb.Append(attribute.Value);
                sb.Append("\"");
            }

            if (IsSelfClosing)
            {
                sb.Append(" />");
            }
            else
            {
                sb.Append(">");
                sb.Append(InnerHtml());
                sb.Append("</");
                sb.Append(TagName);
                sb.Append(">");
            }

            return sb.ToString();
        }
    }
}
