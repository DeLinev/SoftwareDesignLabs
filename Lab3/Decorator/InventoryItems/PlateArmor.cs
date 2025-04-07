using Decorator.Heroes;

namespace Decorator.InventoryItems
{
    public class PlateArmor : HeroDecorator
    {
        public PlateArmor(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " with Plate Armor";
        }

        public override int GetDefensePower()
        {
            return _hero.GetDefensePower() + 7;
        }
    }
}
