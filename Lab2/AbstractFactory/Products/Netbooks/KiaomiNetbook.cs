
using System.Text;

namespace AbstractFactory.Products.Netbooks
{
    public class KiaomiNetbook : INetbook
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public int BatterySize { get; }

        public List<string> InstalledSoftware { get; }

        public KiaomiNetbook(string model, int batterySize)
        {
            Manufacturer = "Kiaomi";
            Model = model;
            BatterySize = batterySize;
            InstalledSoftware = new List<string> { "KiaomiOS", "KiaomiPlayStore" };
        }

        public void ConnectToInternet()
        {
            Console.WriteLine("Connecting to the Internet via Wi-Fi");
        }

        public void InstallSoftware(string softwareName)
        {
            InstalledSoftware.Add(softwareName);
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Kiaomi Netbook Info:")
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
