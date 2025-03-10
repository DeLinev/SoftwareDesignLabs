using System.Text;

namespace AbstractFactory.Products.Ebooks
{
    public class BalaxyEbook : IEbook
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public int PixelDensity { get; }

        public BalaxyEbook(string model, int pixelDensity)
        {
            Manufacturer = "Balaxy";
            Model = model;
            PixelDensity = pixelDensity;
        }

        public void OpenBook(string bookName)
        {
            Console.WriteLine($"Openning book {bookName} in BalaxyLibrary app");
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Balaxy Ebook Info:")
                .AppendLine($"Manufacturer: {Manufacturer}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Pixel Density: {PixelDensity} ppi");

            return info.ToString();
        }
    }
}
