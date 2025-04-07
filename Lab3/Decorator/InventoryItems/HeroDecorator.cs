using Decorator.Heroes;

namespace Decorator.InventoryItems
{
    public class HeroDecorator : IHero
    {
        protected IHero _hero;

        public HeroDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual int GetAttackPower()
        {
            return _hero.GetAttackPower();
        }

        public virtual int GetDefensePower()
        {
            return _hero.GetDefensePower();
        }

        public virtual string GetDescription()
        {
            return _hero.GetDescription();
        }

        public virtual int GetMagicPower()
        {
            return _hero.GetMagicPower();
        }
    }
}
