using System.Text;

namespace AbstractFactory.Products.Laptops
{
    public class BalaxyLaptop : ILaptop
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public float ScreenSize { get; }

        public BalaxyLaptop(string model, float screenSize)
        {
            Manufacturer = "Kiaomi";
            Model = model;
            ScreenSize = screenSize;
        }

        public void InstallOs(string OsName)
        {
            Console.WriteLine($"Installing {OsName} on {Manufacturer} {Model}");
        }

        public void StartWork()
        {
            Console.WriteLine("Launching game to play...");
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Balaxy Laptop Info:")
                .AppendLine($"Manufacturer: {Manufacturer}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Screen size: {ScreenSize} inches");

            return info.ToString();
        }
    }
}
