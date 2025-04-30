namespace Composite.Iterator
{
    public class BreadthIterator : ITreeIterator
    {
        private LightElementNode root;
        private Queue<LightNode> queue;
        private HashSet<LightNode> visitedNodes;

        public BreadthIterator(LightElementNode root)
        {
            this.root = root;
            queue = new Queue<LightNode>();
            queue.Enqueue(root);
            visitedNodes = new HashSet<LightNode>();
        }

        public LightNode? GetNext()
        {
            if (!HasMore())
                return null;

            var currentNode = queue.Dequeue();
            visitedNodes.Add(currentNode);

            if (currentNode is LightElementNode element)
            {
                foreach (var child in element.Children)
                {
                    if (!visitedNodes.Contains(child))
                    {
                        queue.Enqueue(child);
                    }
                }
            }

            return currentNode;
        }

        public bool HasMore()
        {
            return queue.Count > 0;
        }
    }
}
