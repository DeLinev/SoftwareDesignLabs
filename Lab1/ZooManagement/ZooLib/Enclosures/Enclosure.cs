using ZooLib.Animals;

namespace ZooLib.Enclosures
{
    public class Enclosure : IEnclosure, IHabitat
    {
        public Size Size { get; }
        public int Capacity { get; }
        public HabitatType Type { get; }
        public List<IAnimal> Animals { get; }

        public Enclosure(Size size, int capacity, HabitatType type, List<IAnimal> animals)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0.");

            Size = size;
            Capacity = capacity;
            Type = type;
            Animals = new List<IAnimal>();

            if (!CanBeAdded(animals))
            {
                throw new InvalidOperationException("Animals cannot be added to this enclosure.");
            }

            Animals = animals;
        }

        public void AddAnimal(IAnimal animal)
        {
            if (!CanBeAdded(animal))
            {
                throw new InvalidOperationException("Animal cannot be added to this enclosure.");
            }

            Animals.Add(animal);
        }

        public bool CanBeAdded(IAnimal animal)
        {
            if (Animals.Count <= Capacity && animal.PossibleHabitats.Contains(Type))
            {
                return true;
            }

            return false;
        }

        public bool CanBeAdded(List<IAnimal> animals)
        {
            if (Animals.Count + animals.Count > Capacity)
            {
                return false;
            }

            foreach (var animal in animals)
            {
                if (!animal.PossibleHabitats.Contains(Type))
                {
                    return false;
                }
            }

            return true;
        }

        public void RemoveAnimal(IAnimal animal)
        {
            Animals.Remove(animal);
        }
    }
}
