using Decorator.Heroes;

namespace Decorator.InventoryItems
{
    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override int GetAttackPower()
        {
            return _hero.GetAttackPower() + 5;
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " with Sword";
        }
    }
}
