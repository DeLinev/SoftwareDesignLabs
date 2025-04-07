namespace Decorator.Heroes
{
    public class Warrior : IHero
    {
        public string GetDescription() => "Warrior";

        public int GetAttackPower() => 10;

        public int GetDefensePower() => 10;

        public int GetMagicPower() => 0;
    }
}
