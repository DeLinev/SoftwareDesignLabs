namespace Composite.State
{
    public abstract class ElementState
    {
        protected LightElementNode _node;

        public ElementState(LightElementNode node)
        {
            _node = node;
        }

        public abstract void Click();
    }
}
