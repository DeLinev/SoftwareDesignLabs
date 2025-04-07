using Decorator.Heroes;

namespace Decorator.InventoryItems
{
    public class MagicAmulet : HeroDecorator
    {
        public MagicAmulet(IHero hero) : base(hero) { }

        public override int GetDefensePower()
        {
            return _hero.GetDefensePower() + 7;
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " with Magic Amulet";
        }
    }
}
