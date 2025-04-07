namespace Decorator.Heroes
{
    public class Paladin : IHero
    {
        public string GetDescription() => "Paladin";

        public int GetAttackPower() => 5;

        public int GetDefensePower() => 15;

        public int GetMagicPower() => 7;
    }
}
