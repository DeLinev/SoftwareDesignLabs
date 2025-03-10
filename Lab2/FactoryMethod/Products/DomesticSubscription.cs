
using System.Text;

namespace FactoryMethod.Products
{
    public class DomesticSubscription : ISubscription
    {
        public decimal Price { get; }

        public int MinDuration { get; }

        public List<string> Channels { get; }

        public List<string> Features { get; }

        public DomesticSubscription()
        {
            Price = 10.0m;
            MinDuration = 30;
            Channels = new List<string> { "BBC", "ITV", "Channel 4", "Channel 5" };
            Features = new List<string> { "Pause an online broadcast", "View recordings of online broadcasts" };
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder("Domestic Subscription Info:\n");
            info.AppendLine($"Monthly Price: {Price}")
                .AppendLine($"Minimum Duration: {MinDuration} days")
                .Append("Channels: ")
                .AppendJoin(", ", Channels)
                .AppendLine()
                .Append("Features: ")
                .AppendJoin(", ", Features)
                .AppendLine("\nDescription: This subscription is ideal for domestic users who want access to popular local channels and features like pausing and recording broadcasts.");

            return info.ToString();
        }
    }
}
