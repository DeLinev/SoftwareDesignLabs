using System.Text;

namespace AbstractFactory.Products.Laptops
{
    internal class IproneLaptop : ILaptop
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public float ScreenSize { get; }

        public IproneLaptop(string model, float screenSize)
        {
            Manufacturer = "IProne";
            Model = model;
            ScreenSize = screenSize;
        }

        public void InstallOs(string OsName)
        {
            Console.WriteLine($"Installing {OsName} on {Manufacturer} {Model}");
        }

        public void StartWork()
        {
            Console.WriteLine("Launching Final Cut to edit the video...");
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Iprone Laptop Info:")
                .AppendLine($"Manufacturer: {Manufacturer}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Screen size: {ScreenSize} inches");

            return info.ToString();
        }
    }
}
