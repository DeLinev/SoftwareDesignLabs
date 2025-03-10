using System.Text;

namespace AbstractFactory.Products.Smartphones
{
    public class KiaomiSmartphone : ISmartphone
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public string DisplayType { get; }

        public KiaomiSmartphone(string model, string displayType)
        {
            Manufacturer = "Kiaomi";
            Model = model;
            DisplayType = displayType;
        }

        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Making a call to {phoneNumber}...");
        }

        public void OpenCamera()
        {
            Console.WriteLine("Opening Kiaomi camera...");
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
