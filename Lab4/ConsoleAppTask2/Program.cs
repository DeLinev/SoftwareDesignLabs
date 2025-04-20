using Mediator;

class Program
{
    static void Main()
    {
        var commandCentre = new CommandCentre();

        var runway1 = new Runway(commandCentre);
        var runway2 = new Runway(commandCentre);
        var aircraft1 = new Aircraft("Boeing 737", commandCentre);
        var aircraft2 = new Aircraft("Airbus A320", commandCentre);
        var aircraft3 = new Aircraft("Cessna 172", commandCentre);

        aircraft3.RequestLanding();
        aircraft1.RequestTakeOff();
        aircraft3.RequestLanding();

        Console.WriteLine("==========================Current Runway Status==========================");
        Console.WriteLine($"> Runway {runway1.Id} is busy with {runway1.GetAircraftName()}");
        Console.WriteLine($"> Runway {runway2.Id} is busy with {runway2.GetAircraftName()}");
    }
}