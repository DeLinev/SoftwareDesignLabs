namespace ChainOfResponsibility
{
    public abstract class SupportHandler : IHandler
    {
        private IHandler? _nextHandler;
        
        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void Handle();

        protected void HandleNext()
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle();
            }
            else
            {
                Console.WriteLine("No handler found for your request.");
            }
        }
    }
}
