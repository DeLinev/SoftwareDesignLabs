namespace Builder.Builders
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character hero = new Character("Hero");

        public void Reset()
        {
            hero = new Character("Hero");
        }

        public ICharacterBuilder SetDexterity(int dexterity)
        {
            hero.Dexterity = dexterity;
            return this;
        }

        public ICharacterBuilder SetHealth(int health)
        {
            hero.Health = health;
            return this;
        }

        public ICharacterBuilder SetIntelligence(int intelligence)
        {
            hero.Intelligence = intelligence;
            return this;
        }

        public ICharacterBuilder SetMana(int mana)
        {
            hero.Mana = mana;
            return this;
        }

        public ICharacterBuilder SetName(string name)
        {
            hero.Name = name;
            return this;
        }

        public ICharacterBuilder SetRace(string race)
        {
            hero.Race = race;
            return this;
        }

        public ICharacterBuilder SetStrength(int strength)
        {
            hero.Strength = strength;
            return this;
        }

        public ICharacterBuilder GiveItem(string item)
        {
            hero.Items.Add(item);
            return this;
        }

        public ICharacterBuilder PerformDeed(string deed)
        {
            PerformGoodDeed(deed);
            return this;
        }

        private void PerformGoodDeed(string deed)
        {
            hero.Deeds.Add($"Good deed: {deed}");
        }

        public Character GetCharacter()
        {
            Character result = hero;
            Reset();
            return result;
        }
    }
}
