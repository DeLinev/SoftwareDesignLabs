using Builder.Builders;

namespace Builder
{
    public class Director
    {
        private ICharacterBuilder builder;

        public Director(ICharacterBuilder builder)
        {
            this.builder = builder;
        }

        public void SetBuilder(ICharacterBuilder builder)
        {
            this.builder = builder;
        }

        public Character CreateHero()
        {
            return builder
                .SetName("Legolas")
                .SetRace("Elf")
                .SetHealth(100)
                .SetMana(150)
                .SetStrength(10)
                .SetIntelligence(40)
                .SetDexterity(35)
                .GiveItem("Bow")
                .GiveItem("Magic staff")
                .PerformDeed("Saved a cat")
                .GetCharacter();
        }

        public Character CreateEnemy()
        {
            return builder
                .SetName("Uruk-hai")
                .SetRace("Orc")
                .SetHealth(200)
                .SetMana(0)
                .SetStrength(50)
                .SetIntelligence(5)
                .SetDexterity(10)
                .GiveItem("Club")
                .PerformDeed("Burned a village")
                .GetCharacter();
        }
    }
}
