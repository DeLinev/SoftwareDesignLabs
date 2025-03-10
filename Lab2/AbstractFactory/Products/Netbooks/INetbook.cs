namespace AbstractFactory.Products.Netbooks
{
    public interface INetbook
    {
        string Manufacturer { get; }
        string Model { get; }
        int BatterySize { get; }
        List<string> InstalledSoftware { get; }

        void InstallSoftware(string softwareName);
        void ConnectToInternet();
        string GetInfo();
    }
}
