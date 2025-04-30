namespace Composite.Iterator
{
    public interface ITreeIterator
    {
        public LightNode? GetNext();

        public bool HasMore();
    }
}
