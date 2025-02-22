using ZooLib.Animals.Behavior;
using ZooLib.Enclosures;

namespace ZooLib.Animals
{
    public class Lion : IAnimal, ICanRoar
    {
        public string Name { get; }

        public string Species { get; }

        public string Subspecies { get; }

        public Size Size => Size.Medium;

        public List<HabitatType> PossibleHabitats { get; }

        public Lion(string name, string subspecies, List<HabitatType> habitats)
        {
            Name = name;
            Species = "Lion";
            Subspecies = subspecies;
            PossibleHabitats = habitats;
        }

        public void PerformAction()
        {
            Roar();
        }

        public void Roar()
        {
            Console.WriteLine($"The lion {Name} is roaring!");
        }
    }
}
