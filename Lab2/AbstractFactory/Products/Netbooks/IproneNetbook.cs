
using System.Text;

namespace AbstractFactory.Products.Netbooks
{
    public class IproneNetbook : INetbook
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public int BatterySize { get; }

        public List<string> InstalledSoftware { get; }

        public IproneNetbook(string model, int batterySize)
        {
            Manufacturer = "Iprone";
            Model = model;
            BatterySize = batterySize;
            InstalledSoftware = new List<string> { "IproneOS", "IproneStore" };
        }

        public void ConnectToInternet()
        {
            Console.WriteLine("Connecting to the Internet via ethernet");
        }

        public void InstallSoftware(string softwareName)
        {
            InstalledSoftware.Add(softwareName);
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("IProne Netbook Info:")
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
