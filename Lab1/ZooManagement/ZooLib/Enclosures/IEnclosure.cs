using ZooLib.Animals;

namespace ZooLib.Enclosures
{
    public interface IEnclosure
    {
        Size Size { get; }
        List<IAnimal> Animals { get; }

        void AddAnimal(IAnimal animal);
        void RemoveAnimal(IAnimal animal);
        bool CanBeAdded(IAnimal animal);
    }
}
