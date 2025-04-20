namespace ChainOfResponsibility.ConcreteHandlers
{
    public class PaymentSupportHandler : SupportHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Is your issue related to payment problems? (y/n)");
            string? answer = Console.ReadLine();
            if (answer?.ToLower() == "y")
            {
                Console.WriteLine("Try next steps:");
                Console.WriteLine("- Check your payment method.");
                Console.WriteLine("- Ensure you have sufficient funds.");
                Console.WriteLine("- Contact your bank.");
            }
            else
            {
                HandleNext();
            }
        }
    }
}
