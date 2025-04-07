using Decorator.Heroes;

namespace Decorator.InventoryItems
{
    public class MagicCloak : HeroDecorator
    {
        public MagicCloak(IHero hero) : base(hero) { }

        public override int GetDefensePower()
        {
            return _hero.GetDefensePower() + 4;
        }

        public override int GetMagicPower()
        {
            return _hero.GetMagicPower() + 5;
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " with Magic Cloak";
        }
    }
}
