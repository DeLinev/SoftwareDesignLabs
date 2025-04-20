namespace ChainOfResponsibility.ConcreteHandlers
{
    public class SecuritySupportHandler : SupportHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Is your issue related to managing account security and data privacy? (y/n)");
            string? answer = Console.ReadLine();
            if (answer?.ToLower() == "y")
            {
                Console.WriteLine("Try next steps:");
                Console.WriteLine("- Check your privacy settings.");
                Console.WriteLine("- Enable two-factor authentication.");
                Console.WriteLine("- ...");
            }
            else
            {
                HandleNext();
            }
        }
    }
}
