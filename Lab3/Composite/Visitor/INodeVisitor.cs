namespace Composite.Visitor
{
    public interface INodeVisitor
    {
        void Visit(LightElementNode node);
        void Visit(LightTextNode node);
    }
}
