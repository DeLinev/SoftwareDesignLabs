namespace Composite.State
{
    public class ActiveState : ElementState
    {
        public ActiveState(LightElementNode node) : base(node) { }

        public override void Click()
        {
            _node.AddCssClass("inactive");
            _node.SetState(new InactiveState(_node));
        }
    }
}
