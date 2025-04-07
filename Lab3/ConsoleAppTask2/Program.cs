using Decorator.Heroes;
using Decorator.InventoryItems;

class Program
{
    static void Main()
    {
        IHero warrior = new Warrior();
        IHero mage = new Mage();
        IHero paladin = new Paladin();

        Console.WriteLine("Characters description:");
        DescribeHero(warrior);
        DescribeHero(mage);
        DescribeHero(paladin);

        IHero strongWarrior = new PlateArmor(new Sword(warrior));
        IHero powerfulMage = new Staff(new MagicCloak(mage));
        IHero holyPaladin = new MagicAmulet(new Sword(paladin));

        Console.WriteLine("Characters with items description:");
        DescribeHero(strongWarrior);
        DescribeHero(powerfulMage);
        DescribeHero(holyPaladin);
    }

    static void DescribeHero(IHero hero)
    {
        Console.WriteLine("\nHero description: " + hero.GetDescription());
        Console.WriteLine("Attack Power: " + hero.GetAttackPower());
        Console.WriteLine("Defense Power: " + hero.GetDefensePower());
        Console.WriteLine("Magic Power: " + hero.GetMagicPower());
        Console.WriteLine("---------------------------------------------");
    }
}