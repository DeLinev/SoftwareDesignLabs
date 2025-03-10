namespace AbstractFactory.Products.Ebooks
{
    public interface IEbook
    {
        string Manufacturer { get; }
        string Model { get; }
        int PixelDensity { get; }

        void OpenBook(string bookName);
        string GetInfo();
    }
}
