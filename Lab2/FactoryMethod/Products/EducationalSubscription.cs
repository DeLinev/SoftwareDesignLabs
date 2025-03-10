
using System.Text;

namespace FactoryMethod.Products
{
    public class EducationalSubscription : ISubscription
    {
        public decimal Price { get; }

        public int MinDuration { get; }

        public List<string> Channels { get; }

        public List<string> Features { get; }

        public EducationalSubscription()
        {
            Price = 5.0m;
            MinDuration = 90;
            Channels = new List<string> { "Discovery Channel", "National Geographic", "History Channel" };
            Features = new List<string> { "Free access to educational content", "Access to documentaries",
                                        "Pause an online broadcast", "View recordings of online broadcasts"};
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder("Educational Subscription Info:\n");
            info.AppendLine($"Monthly Price: {Price}")
                .AppendLine($"Minimum Duration: {MinDuration} days")
                .Append("Channels: ")
                .AppendJoin(", ", Channels)
                .AppendLine()
                .Append("Features: ")
                .AppendJoin(", ", Features)
                .AppendLine("\nDescription: This subscription is ideal for students who want access to educational conten.");

            return info.ToString();
        }
    }
}
