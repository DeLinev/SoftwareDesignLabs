namespace Mediator
{
    public class CommandCentre : ICommandCentre
    {
        private Dictionary<Runway, Aircraft?> _runwayAircraft = new();

        public void AddAircraft(Aircraft aircraft)
        {
            if (_runwayAircraft.ContainsValue(aircraft))
            {
                Console.WriteLine($"> Aircraft {aircraft.Name} already exists.");
                return;
            }

            foreach (var runway in _runwayAircraft.Keys)
            {
                if (runway.IsAvailable)
                {
                    _runwayAircraft[runway] = aircraft;
                    runway.IsAvailable = false;
                    aircraft.IsLanded = true;
                    return;
                }
            }

            Console.WriteLine($"> No available runway for {aircraft.Name} at {DateTime.Now}");
        }

        public void AddRunway(Runway runway)
        {
            if (_runwayAircraft.ContainsKey(runway))
            {
                Console.WriteLine($"> Runway {runway.Id} already exists.");
                return;
            }

            _runwayAircraft.Add(runway, null);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            Console.WriteLine($"> Requesting landing for {aircraft.Name} at {DateTime.Now}");
            foreach (var runway in _runwayAircraft.Keys)
            {
                if (runway.IsAvailable)
                {
                    runway.IsAvailable = false;
                    aircraft.IsLanded = true;
                    _runwayAircraft[runway] = aircraft;
                    Console.WriteLine($"> Landing granted for {aircraft.Name} on runway {runway.Id}");
                    runway.HighLightRed();
                    return;
                }
            }

            Console.WriteLine($"> No available runway for {aircraft.Name} at {DateTime.Now}");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"> Requesting takeoff for {aircraft.Name} at {DateTime.Now}");
            foreach (var runway in _runwayAircraft.Keys)
            {
                if (_runwayAircraft[runway] == aircraft)
                {
                    runway.IsAvailable = true;
                    aircraft.IsLanded = false;
                    _runwayAircraft[runway] = null;
                    Console.WriteLine($"> Takeoff granted for {aircraft.Name} from runway {runway.Id}");
                    runway.HighLightGreen();
                    return;
                }
            }
        }

        public string GetAircraftName(Runway runway)
        {
            if (_runwayAircraft.TryGetValue(runway, out var aircraft))
            {
                return aircraft?.Name ?? "No aircraft on runway.";
            }
            return "Runway not found.";
        }
    }
}
