namespace FactoryMethod.Products
{
    public interface ISubscription
    {
        decimal Price { get; }

        int MinDuration { get; }

        List<string> Channels { get; }

        List<string> Features { get; }

        string GetInfo();
    }
}
