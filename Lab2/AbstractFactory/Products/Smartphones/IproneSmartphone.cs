using System.Text;

namespace AbstractFactory.Products.Smartphones
{
    public class IproneSmartphone : ISmartphone
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public string DisplayType { get; }

        public IproneSmartphone(string model, string displayType)
        {
            Manufacturer = "IProne";
            Model = model;
            DisplayType = displayType;
        }

        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber}...");
        }

        public void OpenCamera()
        {
            Console.WriteLine("Opening Iprone camera...");
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
