namespace AbstractFactory.Products.Smartphones
{
    public interface ISmartphone
    {
        string Manufacturer { get; }
        string Model { get; }
        string DisplayType { get; }

        void OpenCamera();
        void MakeCall(string phoneNumber);
        string GetInfo();
    }
}
