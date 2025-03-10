using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class MobileApp : SubscriptionCreator
    {
        public override ISubscription CreateDomesticSubsription()
        {
            Console.WriteLine("Creating a domestic subscription on the mobile app...");
            Console.WriteLine("Payment via Google/Apple Pay");
            Thread.Sleep(1500);
            Console.WriteLine("Subscription created successfully!");
            return new DomesticSubscription();
        }

        public override ISubscription CreateEducationalSubsription()
        {
            Console.WriteLine("Creating an educational subscription on the mobile app...");
            Console.WriteLine("Processing of educational documents...");
            Thread.Sleep(1500);
            Console.WriteLine("Payment via Google/Apple Pay");
            Thread.Sleep(1500);
            Console.WriteLine("Subscription created successfully!");
            return new EducationalSubscription();
        }

        public override ISubscription CreatePremiumSubscription()
        {
            Console.WriteLine("Creating a premium subscription on the mobile app...");
            Console.WriteLine("Payment via Google/Apple Pay");
            Thread.Sleep(1500);
            Console.WriteLine("Subscription created successfully!");
            return new PremiumSubscription();
        }
    }
}
