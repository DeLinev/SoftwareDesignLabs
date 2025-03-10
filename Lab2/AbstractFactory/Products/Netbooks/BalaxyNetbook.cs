using System.Text;

namespace AbstractFactory.Products.Netbooks
{
    public class BalaxyNetbook : INetbook
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public int BatterySize { get; }

        public List<string> InstalledSoftware { get; }

        public BalaxyNetbook(string model, int batterySize)
        {
            Manufacturer = "Balaxy";
            Model = model;
            BatterySize = batterySize;
            InstalledSoftware = new List<string> { "BalaxDroid", "BalaxyStore" };
        }

        public void ConnectToInternet()
        {
            Console.WriteLine("Connecting to the Internet via magic technologies");
        }

        public void InstallSoftware(string softwareName)
        {
            InstalledSoftware.Add(softwareName);
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Balaxy Netbook Info:")
                .AppendLine($"Manufacturer: {Manufacturer}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Battery Size: {BatterySize} wh")
                .Append("Installed Software: ")
                .AppendJoin(", ", InstalledSoftware)
                .AppendLine();

            return info.ToString();
        }
    }
}
