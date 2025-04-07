namespace Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHtml();

        public abstract string InnerHtml();

        public abstract int ChildElementsCount();
    }
}
