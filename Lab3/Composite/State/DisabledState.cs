namespace Composite.State
{
    public class DisabledState : ElementState
    {
        public DisabledState(LightElementNode node) : base(node) 
        {
            _node.RemoveCssClass("inactive");
            _node.AddCssClass("disabled");
        }
        
        public override void Click()
        {
            return;
        }
    }
}
