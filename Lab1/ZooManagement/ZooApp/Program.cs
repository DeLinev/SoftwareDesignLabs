using ZooLib;
using ZooLib.Animals;
using ZooLib.Employees;
using ZooLib.Employees.Roles;
using ZooLib.Enclosures;
using ZooLib.Inventories;

class Program
{
    static void Main()
    {
        var lion1 = new Lion("Simba", "Asiatic Lion", [HabitatType.Savanna]);
        var lion2 = new Lion("Mufasa", "African Lion", [HabitatType.Savanna]);

        var elephant = new Elephant("Dumbo", "African Elephant", [HabitatType.Savanna]);

        var koala1 = new Koala("Blinky", "Queensland Koala", [HabitatType.EucalyptusForest]);
        var koala2 = new Koala("Nutsy", "New South Wales Koala", [HabitatType.EucalyptusForest]);
        var koala3 = new Koala("Marcia", "Victoria Koala", [HabitatType.EucalyptusForest]);
        var koalas = new List<IAnimal> { koala1, koala2 };

        var lionEnclosure = new Enclosure(Size.Medium, 5, HabitatType.Savanna, [lion1, lion2]);
        var elephantEnclosure = new Enclosure(Size.Large, 2, HabitatType.Savanna, [elephant]);
        var koalaEnclosure = new Enclosure(Size.Small, 3, HabitatType.EucalyptusForest, [koala1, koala2]);
        koalaEnclosure.AddAnimal(koala3);

        var enclosures = new List<Enclosure> { lionEnclosure };

        var zookeeper = new Employee("John", new Zookeeper());
        var veterinarian = new Employee("Jane", new Veterinarian());
        var tourGuide = new Employee("Jack", new TourGuide());

        var animalInventory = new AnimalsInventory([lionEnclosure, elephantEnclosure, koalaEnclosure]);
        var employeeInventory = new EmployeesInventory([zookeeper, veterinarian, tourGuide]);

        Console.WriteLine("Number of Enclosures: " + animalInventory.GetEnclosuresCount());
        Console.WriteLine("Enclosures with Animals:");
        animalInventory.DisplayEnclosuresWithAnimals();
        Console.WriteLine("Total Number of Animals: " + animalInventory.GetAnimalsCount());

        Console.WriteLine("Number of Employees: " + employeeInventory.GetEmployeesCount());
        Console.WriteLine("Employees:");
        employeeInventory.DisplayEmployees();

        Console.WriteLine("""
            --------------------
            ***Start Working***
            --------------------
            """);

        employeeInventory.StartWork();
        animalInventory.PerformDailyRoutine();
    }
}