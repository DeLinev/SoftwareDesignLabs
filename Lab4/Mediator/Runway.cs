namespace Mediator
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsAvailable { get; set; } = true;
        private ICommandCentre commandCentre;

        public Runway(ICommandCentre commandCentre)
        {
            this.commandCentre = commandCentre;
            commandCentre.AddRunway(this);
        }

        public void HighLightRed()
        {
            Console.WriteLine($"- Runway {Id} is busy");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"+ Runway {Id} is available");
        }

        public string GetAircraftName()
        {
            return commandCentre.GetAircraftName(this);
        }
    }
}
