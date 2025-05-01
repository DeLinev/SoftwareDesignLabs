using System.Xml.Linq;

namespace Composite.State
{
    public class InactiveState : ElementState
    {
        public InactiveState(LightElementNode node) : base(node) { }

        public override void Click()
        {
            _node.RemoveCssClass("inactive");
            _node.SetState(new ActiveState(_node));
        }
    }
}
