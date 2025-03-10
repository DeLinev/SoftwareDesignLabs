namespace Builder.Builders
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character enemy = new Character("Enemy");

        public void Reset()
        {
            enemy = new Character("Enemy");
        }

        public ICharacterBuilder SetDexterity(int dexterity)
        {
            enemy.Dexterity = dexterity;
            return this;
        }

        public ICharacterBuilder SetHealth(int health)
        {
            enemy.Health = health;
            return this;
        }

        public ICharacterBuilder SetIntelligence(int intelligence)
        {
            enemy.Intelligence = intelligence;
            return this;
        }

        public ICharacterBuilder SetMana(int mana)
        {
            enemy.Mana = mana;
            return this;
        }

        public ICharacterBuilder SetName(string name)
        {
            enemy.Name = name;
            return this;
        }

        public ICharacterBuilder SetRace(string race)
        {
            enemy.Race = race;
            return this;
        }

        public ICharacterBuilder SetStrength(int strength)
        {
            enemy.Strength = strength;
            return this;
        }

        public ICharacterBuilder GiveItem(string item)
        {
            enemy.Items.Add(item);
            return this;
        }

        public ICharacterBuilder PerformDeed(string deed)
        {
            PerformBadDeed(deed);
            return this;
        }

        private void PerformBadDeed(string deed)
        {
            enemy.Deeds.Add($"Bad deed: {deed}");
        }

        public Character GetCharacter()
        {
            Character result = enemy;
            Reset();
            return result;
        }
    }
}
