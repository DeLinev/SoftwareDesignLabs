using Decorator.Heroes;

namespace Decorator.InventoryItems
{
    public class Staff : HeroDecorator
    {
        public Staff(IHero hero) : base(hero) { }

        public override int GetAttackPower()
        {
            return _hero.GetAttackPower() + 2;
        }

        public override int GetMagicPower()
        {
            return _hero.GetMagicPower() + 6;
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " with Staff";
        }
    }
}
