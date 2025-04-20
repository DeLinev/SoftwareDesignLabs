namespace ChainOfResponsibility.ConcreteHandlers
{
    public class AccountSupportHandler : SupportHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Is your issue related to problems creating or logging into your account? (y/n)");
            string? answer = Console.ReadLine();
            if (answer?.ToLower() == "y")
            {
                Console.WriteLine("Try next steps:");
                Console.WriteLine("- Reset your password.");
                Console.WriteLine("- Check your email for verification.");
                Console.WriteLine("- ... ");
            }
            else
            {
                HandleNext();
            }
        }
    }
}
