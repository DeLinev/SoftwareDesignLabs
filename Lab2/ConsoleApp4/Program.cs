using Prototype;

class Program
{
    static void Main()
    {
        var oldestAncestor = new Virus(9, 7, "Zephyr", "Draconivirus");

        var parent1 = new Virus(7, 6, "Razor", "Draconivirus");
        var parent2 = new Virus(5, 5, "Blade", "Draconivirus");

        var child1 = new Virus(3, 4, "Scissors", "Draconivirus");
        var child2 = new Virus(2, 3, "Scythe", "Draconivirus");
        var child3 = new Virus(1, 2, "Knife", "Draconivirus");

        parent1.AddChild(child1);
        parent2.AddChild(child2);
        parent2.AddChild(child3);

        oldestAncestor.AddChild(parent1);
        oldestAncestor.AddChild(parent2);

        Console.WriteLine("Original Virus Family");
        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        Console.WriteLine(oldestAncestor.GetInfo());

        Virus clone = (Virus)oldestAncestor.Clone();

        Console.WriteLine("Cloned Virus Family");
        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        Console.WriteLine(clone.GetInfo());

        clone.Age = 11;
        clone.Weight = 15;

        Console.WriteLine("Original Virus Family (after clone alteration)");
        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        Console.WriteLine(oldestAncestor.GetInfo());

        Console.WriteLine("Altered Clone Virus Family");
        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        Console.WriteLine(clone.GetInfo());
    }
}
