using ZooLib.Animals.Behavior;
using ZooLib.Enclosures;

namespace ZooLib.Animals
{
    public class Koala : IAnimal, ICanClimb
    {
        public string Name { get; }

        public string Species { get; }

        public string Subspecies { get; }

        public Size Size => Size.Small;

        public List<HabitatType> PossibleHabitats { get; }

        public Koala(string name, string subspecies, List<HabitatType> habitats)
        {
            Name = name;
            Species = "Koala";
            Subspecies = subspecies;
            PossibleHabitats = habitats;
        }

        public void PerformAction()
        {
            Climb();
        }

        public void Climb()
        {
            Console.WriteLine($"The koala {Name} is climbing a tree!");
        }
    }
}
