using FactoryMethod.Creators;
using FactoryMethod.Products;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose purchase method:");
        Console.WriteLine("1. WebSite");
        Console.WriteLine("2. Mobile App");
        Console.WriteLine("3. Manager Call");
        Console.Write("-> ");

        string? choice = Console.ReadLine();
        var creator = GetCreator(choice);

        Console.WriteLine("Choose subscription type:");
        Console.WriteLine("1. Domestic");
        Console.WriteLine("2. Educational");
        Console.WriteLine("3. Premium");
        Console.Write("-> ");

        choice = Console.ReadLine();
        ISubscription subscription = GetSubscription(creator, choice);

        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        Console.WriteLine(subscription.GetInfo());
    }

    static SubscriptionCreator GetCreator(string? choice)
    {
        switch (choice)
        {
            case "1":
                return new WebSite();
            case "2":
                return new MobileApp();
            case "3":
                return new ManagerCall();
            default:
                throw new ArgumentException("Invalid choice");
        }
    }

    static ISubscription GetSubscription(SubscriptionCreator creator, string? choice)
    {
        switch (choice)
        {
            case "1":
                return creator.CreateDomesticSubsription();
            case "2":
                return creator.CreateEducationalSubsription();
            case "3":
                return creator.CreatePremiumSubscription();
            default:
                throw new ArgumentException("Invalid choice");
        }
    }
}