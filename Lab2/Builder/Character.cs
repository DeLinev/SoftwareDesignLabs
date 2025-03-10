using System.Text;

namespace Builder
{
    public class Character
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public List<string> Deeds { get; set; } = new List<string>();

        public Character(string type)
        {
            Type = type;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"{Type} Info:")
                .AppendLine($"Name: {Name}")
                .AppendLine($"Race: {Race}")
                .AppendLine($"Health: {Health}")
                .AppendLine($"Mana: {Mana}")
                .AppendLine($"Strength: {Strength}")
                .AppendLine($"Dexterity: {Dexterity}")
                .AppendLine($"Intelligence: {Intelligence}")
                .Append("Items: ")
                .AppendJoin(", ", Items)
                .AppendLine()
                .Append("Deeds: ")
                .AppendJoin(", ", Deeds)
                .AppendLine();

            return info.ToString();
        }
    }
}
