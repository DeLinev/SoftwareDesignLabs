using ChainOfResponsibility.ConcreteHandlers;

class Program
{
    static void Main()
    {
        var accountHandler = new AccountSupportHandler();
        var paymentHandler = new PaymentSupportHandler();
        var securityHandler = new SecuritySupportHandler();
        var technicalHandler = new TechnicalSupportHandler();

        accountHandler
            .SetNext(paymentHandler)
            .SetNext(securityHandler)
            .SetNext(technicalHandler)
            .SetNext(accountHandler);
        

        Console.WriteLine("Welcome to the support system!");
        accountHandler.Handle();
    }
}