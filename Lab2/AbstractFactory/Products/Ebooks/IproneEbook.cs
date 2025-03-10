using System.Text;

namespace AbstractFactory.Products.Ebooks
{
    public class IproneEbook : IEbook
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public int PixelDensity { get; }

        public IproneEbook(string model, int pixelDensity)
        {
            Manufacturer = "IProne";
            Model = model;
            PixelDensity = pixelDensity;
        }

        public void OpenBook(string bookName)
        {
            Console.WriteLine($"Openning book {bookName} in IproneReader app");
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Iprone Ebook Info:")
                .AppendLine($"Manufacturer: {Manufacturer}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Pixel Density: {PixelDensity} ppi");

            return info.ToString();
        }
    }
}
