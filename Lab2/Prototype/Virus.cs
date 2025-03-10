using System.Text;

namespace Prototype
{
    public class Virus : Prototype
    {
        public int Weight {get; set; }
        public int Age { get; set; }

        private string name;
        private string species;
        private List<Virus> children;

        public Virus(int weight, int age, string name, string species)
        {
            Weight = weight;
            Age = age;
            this.name = name;
            this.species = species;
            children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            children.Add(child);
        }

        public Prototype Clone()
        {
            Virus clone = new Virus(Weight, Age, name, species);

            foreach (Virus child in children)
            {
                clone.AddChild((Virus)child.Clone());
            }

            return clone;
        }

        public string GetInfo(string indent = "")
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"{indent}Virus Info:")
                .AppendLine($"{indent}Name: {name}")
                .AppendLine($"{indent}Species: {species}")
                .AppendLine($"{indent}Weight: {Weight}")
                .AppendLine($"{indent}Age: {Age}")
                .AppendLine($"{indent}Children:");

            foreach (Virus child in children)
            {
                info.AppendLine("---------------");
                info.Append(child.GetInfo(indent + "  "));
            }

            return info.ToString();
        }
    }
}
