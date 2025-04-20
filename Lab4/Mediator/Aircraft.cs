namespace Mediator
{
    public class Aircraft
    {
        public string Name { get; set; }
        public bool IsLanded { get; set; } = false;
        private ICommandCentre commandCentre;

        public Aircraft(string name, ICommandCentre commandCentre)
        {
            Name = name;
            this.commandCentre = commandCentre;
            commandCentre.AddAircraft(this);
        }

        public void RequestLanding()
        {
            if (IsLanded)
            {
                Console.WriteLine($"* {Name} is already landed.");
                return;
            }

            commandCentre.RequestLanding(this);
        }

        public void RequestTakeOff()
        {
            if (!IsLanded)
            {
                Console.WriteLine($"* {Name} is already in the air.");
                return;
            }

            commandCentre.RequestTakeOff(this);
        }
    }
}
