namespace Composite.Observer
{
    public class EventManager
    {
        private Dictionary<string, List<IEventListener>> listeners = new();

        public void Subscribe(string eventName, IEventListener listener)
        {
            if (!listeners.ContainsKey(eventName))
            {
                listeners[eventName] = new List<IEventListener>();
            }
            listeners[eventName].Add(listener);
        }

        public void Unsubscribe(string eventName, IEventListener listener)
        {
            if (listeners.ContainsKey(eventName))
            {
                listeners[eventName].Remove(listener);
            }
        }

        public void Notify(string eventName, object sender)
        {
            if (listeners.ContainsKey(eventName))
            {
                foreach (var listener in listeners[eventName])
                {
                    listener.Update(sender, eventName);
                }
            }
        }
    }
}
