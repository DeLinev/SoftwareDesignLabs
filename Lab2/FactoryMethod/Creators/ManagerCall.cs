using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class ManagerCall : SubscriptionCreator
    {
        public override ISubscription CreateDomesticSubsription()
        {
            Console.WriteLine("Creating a domestic subscription via call...");
            Console.WriteLine("Request for payment data of the client");
            Thread.Sleep(1500);
            Console.WriteLine("Order placement by the manager");
            Thread.Sleep(1500);
            Console.WriteLine("Subscription created successfully!");
            return new DomesticSubscription();
        }

        public override ISubscription CreateEducationalSubsription()
        {
            Console.WriteLine("Creating an educational subscription via call...");
            Console.WriteLine("Request for educational documents");
            Thread.Sleep(1500);
            Console.WriteLine("Request for payment data of the client");
            Thread.Sleep(1500);
            Console.WriteLine("Order placement by the manager");
            Thread.Sleep(1500);
            Console.WriteLine("Subscription created successfully!");
            return new EducationalSubscription();
        }

        public override ISubscription CreatePremiumSubscription()
        {
            Console.WriteLine("Creating a premium subscription via call...");
            Console.WriteLine("Request for payment data of the client");
            Thread.Sleep(1500);
            Console.WriteLine("Order placement by the manager");
            Thread.Sleep(1500);
            Console.WriteLine("Subscription created successfully!");
            return new PremiumSubscription();
        }
    }
}
