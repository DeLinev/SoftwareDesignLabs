using System.Text;

namespace AbstractFactory.Products.Laptops
{
    public class KiaomiLaptop : ILaptop
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public float ScreenSize { get; }

        public KiaomiLaptop(string model, float screenSize)
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
            Console.WriteLine("Launching Visual Studio to write the code...");
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Kiaomi Laptop Info:")
                .AppendLine($"Manufacturer: {Manufacturer}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Screen size: {ScreenSize} inches");
            return info.ToString();
        }
    }
}
