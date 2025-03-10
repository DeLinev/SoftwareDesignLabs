using Builder;
using Builder.Builders;

class Program
{
    static void Main()
    {
        var heroBuilder = new HeroBuilder();
        var director = new Director(heroBuilder);
        var hero = director.CreateHero();

        var enemyBuilder = new EnemyBuilder();
        director.SetBuilder(enemyBuilder);
        var enemy = director.CreateEnemy();

        var customHero = heroBuilder
            .SetName("Aragorn")
            .SetRace("Human")
            .SetHealth(150)
            .SetMana(50)
            .SetStrength(20)
            .SetIntelligence(30)
            .SetDexterity(25)
            .GiveItem("Sword")
            .GiveItem("Shield")
            .PerformDeed("Defeated the dark lord")
            .GetCharacter();

        Console.WriteLine(hero);
        Console.WriteLine(enemy);
        Console.WriteLine(customHero);
    }
}
