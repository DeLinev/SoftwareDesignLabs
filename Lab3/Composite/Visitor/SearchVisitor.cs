using System.Text.RegularExpressions;

namespace Composite.Visitor
{
    public class SearchVisitor : INodeVisitor
    {
        public string TagName { get; }
        public string[] CssClasses { get; }
        public string RegEx { get; }
        public List<LightElementNode> ElementMatches { get; private set; }
        public List<LightTextNode> TextMatches { get; private set; }

        public SearchVisitor(string tagName, string regEx, params string[] cssClasses)
        {
            TagName = tagName;
            CssClasses = cssClasses;
            ElementMatches = new List<LightElementNode>();
            TextMatches = new List<LightTextNode>();
            RegEx = regEx;
        }

        public void Visit(LightElementNode node)
        {
            bool tagMatch = string.IsNullOrEmpty(TagName) || node.TagName.Equals(TagName, StringComparison.OrdinalIgnoreCase);
            bool classMatch = CssClasses.Length == 0 || CssClasses.All(css => node.CssClasses.Contains(css));

            if (tagMatch && classMatch)
            {
                ElementMatches.Add(node);
            }
        }

        public void Visit(LightTextNode node)
        {
            if (string.IsNullOrEmpty(RegEx) || Regex.IsMatch(node.Text, RegEx))
            {
                TextMatches.Add(node);
            }
        }
    }
}
