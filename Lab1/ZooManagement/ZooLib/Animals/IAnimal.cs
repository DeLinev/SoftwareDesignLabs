using ZooLib.Enclosures;

namespace ZooLib.Animals
{
    public interface IAnimal
    {
        public string Name { get; }
        public string Species { get; }
        public string Subspecies { get; }
        public Size Size { get; }
        public List<HabitatType> PossibleHabitats { get; }

        public void PerformAction();
    }
}
