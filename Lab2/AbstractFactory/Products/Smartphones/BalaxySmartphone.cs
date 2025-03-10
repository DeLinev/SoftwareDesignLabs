using System.Text;

namespace AbstractFactory.Products.Smartphones
{
    public class BalaxySmartphone : ISmartphone
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public string DisplayType { get; }

        public BalaxySmartphone(string model, string displayType)
        {
            Manufacturer = "Balaxy";
            Model = model;
            DisplayType = displayType;
        }

        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Initiating call to {phoneNumber}...");
        }

        public void OpenCamera()
        {
            Console.WriteLine("Opening Balaxy camera...");
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("IProne Smartphone Info:")
                .AppendLine($"Manufacturer: {Manufacturer}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Display Type: {DisplayType}");

            return info.ToString();
        }
    }
}
