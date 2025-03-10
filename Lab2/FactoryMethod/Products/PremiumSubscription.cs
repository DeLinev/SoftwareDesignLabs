using System.Text;

namespace FactoryMethod.Products
{
    public class PremiumSubscription : ISubscription
    {
        public decimal Price { get; }

        public int MinDuration { get; }

        public List<string> Channels { get; }

        public List<string> Features { get; }

        public PremiumSubscription()
        {
            Price = 20.0m;
            MinDuration = 30;
            Channels = new List<string> { "BBC", "ITV", "Channel 4", "Channel 5", "Discovery Channel", "National Geographic", "History Channel" };
            Features = new List<string> { "Access to all channels", "Content in 4k", "Pause an online broadcast", 
                                        "View recordings of online broadcasts", "Access to premium channels",
                                        "Offline viewing"};
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder("Premium Subscription Info:\n");
            info.AppendLine($"Monthly Price: {Price}")
                .AppendLine($"Minimum Duration: {MinDuration} days")
                .Append("Channels: ")
                .AppendJoin(", ", Channels)
                .AppendLine()
                .Append("Features: ")
                .AppendJoin(", ", Features)
                .AppendLine("\nDescription: This subscription is ideal for users who want access to all channels, premium content, and features like offline viewing.");

            return info.ToString();
        }
    }
}
