using ZooLib.Enclosures;

namespace ZooLib.Inventories
{
    public class AnimalsInventory
    {
        private List<Enclosure> _enclosures;

        public AnimalsInventory(List<Enclosure> enclosures)
        {
            _enclosures = enclosures;
        }

        public void DisplayEnclosuresWithAnimals()
        {
            int animalCount = 0;
            Console.WriteLine("Number of Enclosures: " + _enclosures.Count);
            Console.WriteLine("Enclosures with Animals:");
            foreach (var enclosure in _enclosures)
            {
                animalCount += enclosure.Animals.Count;
                Console.WriteLine($"Enclosure Type: {enclosure.Type}, Size: {enclosure.Size}, Capacity: {enclosure.Capacity}");
                foreach (var animal in enclosure.Animals)
                {
                    Console.WriteLine($"  - Animal Name: {animal.Name}, Species: {animal.Species}, Subspecies: {animal.Subspecies}");
                }
            }
            Console.WriteLine("Total Number of Animals: " + animalCount);
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            _enclosures.Add(enclosure);
        }

        public void PerformDailyRoutine()
        {
            foreach (var enclosure in _enclosures)
            {
                foreach (var animal in enclosure.Animals)
                {
                    animal.PerformAction();
                }
            }
        }
    }
} 
