namespace Composite.Observer
{
    public interface IEventListener
    {
        void Update(object sender, string eventName);
    }
}
