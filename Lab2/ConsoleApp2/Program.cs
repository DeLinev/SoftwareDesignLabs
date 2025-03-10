using AbstractFactory.Creators;
using AbstractFactory.Products.Ebooks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose manufacturer:");
        Console.WriteLine("1. IProne");
        Console.WriteLine("2. Balaxy");
        Console.WriteLine("3. Kiaomi");
        Console.Write("-> ");

        string? choice = Console.ReadLine();
        var creator = GetCreator(choice);

        var laptop = creator.CreateLaptop();
        laptop.InstallOs("Windows 10");
        laptop.StartWork();
        Console.WriteLine(laptop.GetInfo());

        var netbook = creator.CreateNetbook();
        netbook.ConnectToInternet();
        netbook.InstallSoftware("Office 365");
        Console.WriteLine(netbook.GetInfo());

        var ebook = creator.CreateEbook();
        ebook.OpenBook("Design Patterns");
        Console.WriteLine(ebook.GetInfo());

        var smartphone = creator.CreateSmartphone();
        smartphone.MakeCall("123-456-789");
        Console.WriteLine(smartphone.GetInfo());
    }

    static IDeviceCreator GetCreator(string? choice)
    {
        switch (choice)
        {
            case "1":
                return new IproneCreator();
            case "2":
                return new BalaxyCreator();
            case "3":
                return new KiaomiCreator();
            default:
                throw new ArgumentException("Invalid choice");
        }
    }
}