using Composite;

namespace Flyweight
{
    public class LightElementFactory
    {
        private Dictionary<string, LightElementNode> cachedElements = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElement(string tagName, bool isBlock = true, bool isSelfClosing = false)
        {
            string key = tagName + isBlock.ToString() + isSelfClosing.ToString();

            if (!cachedElements.ContainsKey(key))
            {
                cachedElements[tagName] = new LightElementNode(tagName, isBlock, isSelfClosing);
            }
            return cachedElements[tagName];
        }

        public LightElementNode CreateElementWithText(string tagName, string text, bool isBlock = true)
        {
            LightElementNode element = new LightElementNode(tagName, isBlock);
            element.AddChild(new LightTextNode(text));
            return element;
        }
    }
}
