using ZooLib.Animals.Behavior;
using ZooLib.Enclosures;

namespace ZooLib.Animals
{
    public class Elephant : IAnimal, ICanSwim
    {
        public string Name { get; }

        public string Species { get; }

        public string Subspecies { get; }

        public Size Size => Size.Large;

        public List<HabitatType> PossibleHabitats { get; }

        public Elephant(string name, string subspecies, List<HabitatType> habitats)
        {
            Name = name;
            Species = "Elephant";
            Subspecies = subspecies;
            PossibleHabitats = habitats;
        }

        public void PerformAction()
        {
            Swim();
        }

        public void Swim()
        {
            Console.WriteLine($"The elephant {Name} is swimming!");
        }
    }
}
