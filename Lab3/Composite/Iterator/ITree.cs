namespace Composite.Iterator
{
    public interface ITree
    {
        public void AddChild(LightNode child);
        public void RemoveChild(LightNode child);
        public ITreeIterator CreateDeepthIterator();
        public ITreeIterator CreateBreadthIterator();
    }
}
