namespace Decorator.Heroes
{
    public class Mage : IHero
    {
        public string GetDescription() => "Mage";

        public int GetAttackPower() => 3;

        public int GetDefensePower() => 5;

        public int GetMagicPower() => 12;
    }
}
