namespace Composite
{
    public abstract class LightNode
    {
        public string Render()
        {
            OnCreated();
            OnInserted();
            OnClassListApplied();
            OnTextSanitize();
            string html = RenderOuterHtml();
            OnRendered();
            return html;
        }

        public abstract string OuterHtml();
        public abstract string InnerHtml();
        public abstract string RenderOuterHtml();
        public abstract string RenderInnerHtml();
        public abstract int ChildElementsCount();

        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnRendered() { }
        protected virtual void OnTextSanitize() { }
    }
}
