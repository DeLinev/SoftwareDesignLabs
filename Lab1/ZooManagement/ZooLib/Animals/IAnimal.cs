using ZooLib.Enclosures;

namespace ZooLib.Animals
{
    public interface IAnimal
    {
        string Name { get; }
        string Species { get; }
        string Subspecies { get; }
        Size Size { get; }
        List<HabitatType> PossibleHabitats { get; }

        void PerformAction();
    }
}
