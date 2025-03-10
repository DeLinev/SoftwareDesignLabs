namespace AbstractFactory.Products.Laptops
{
    public interface ILaptop
    {
        string Manufacturer { get; }
        string Model { get; }
        float ScreenSize { get; }

        void InstallOs(string OsName);
        void StartWork();
        string GetInfo();
    }
}
