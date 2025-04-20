namespace Mediator
{
    public interface ICommandCentre
    {
        void RequestLanding(Aircraft aircraft);
        void RequestTakeOff(Aircraft aircraft);
        void AddRunway(Runway runway);
        void AddAircraft(Aircraft aircraft);
        string GetAircraftName(Runway runway);
    }
}
