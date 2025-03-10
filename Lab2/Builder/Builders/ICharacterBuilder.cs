namespace Builder.Builders
{
    public interface ICharacterBuilder
    {
        void Reset();
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHealth(int health);
        ICharacterBuilder SetMana(int mana);
        ICharacterBuilder SetStrength(int strength);
        ICharacterBuilder SetIntelligence(int intelligence);
        ICharacterBuilder SetDexterity(int dexterity);
        ICharacterBuilder SetRace(string race);
        ICharacterBuilder GiveItem(string item);
        ICharacterBuilder PerformDeed(string deed);
        Character GetCharacter();
    }
}
