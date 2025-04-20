namespace ChainOfResponsibility
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle();
    }
}
