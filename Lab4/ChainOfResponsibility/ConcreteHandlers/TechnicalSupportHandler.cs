namespace ChainOfResponsibility.ConcreteHandlers
{
    public class TechnicalSupportHandler : SupportHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Is your issue related to technical problems? (y/n)");
            string? answer = Console.ReadLine();
            if (answer?.ToLower() == "y")
            {
                Console.WriteLine("Try next steps:");
                Console.WriteLine("- Restart your device.");
                Console.WriteLine("- Check for software updates.");
                Console.WriteLine("- Clear cache and cookies.");
            }
            else
            {
                HandleNext();
            }
        }
    }
}
