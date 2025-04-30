namespace Composite.Iterator
{
    public class DepthIterator : ITreeIterator
    {
        private LightElementNode root;
        private Stack<LightNode> stack;
        private HashSet<LightNode> visitedNodes;

        public DepthIterator(LightElementNode root)
        {
            this.root = root;
            stack = new Stack<LightNode>();
            stack.Push(root);
            visitedNodes = new HashSet<LightNode>();
        }

        public LightNode? GetNext()
        {
            if (!HasMore())
                return null;

            var currentNode = stack.Pop();
            visitedNodes.Add(currentNode);

            if (currentNode is LightElementNode element)
            {
                for (int i = element.Children.Count - 1; i >= 0; i--)
                {
                    var child = element.Children[i];
                    if (!visitedNodes.Contains(child))
                    {
                        stack.Push(child);
                    }
                }
            }

            return currentNode;
        }

        public bool HasMore()
        {
            return stack.Count > 0;
        }
    }
}
