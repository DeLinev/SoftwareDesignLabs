using System.Text;

namespace AbstractFactory.Products.Ebooks
{
    public class KiaomiEbook : IEbook
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public int PixelDensity { get; }

        public KiaomiEbook(string model, int pixelDensity)
        {
            Manufacturer = "Kiaomi";
            Model = model;
            PixelDensity = pixelDensity;
        }

        public void OpenBook(string bookName)
        {
            Console.WriteLine($"Openning book {bookName} in KiaomiBooks app");
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Kiaomi Ebook Info:")
                .AppendLine($"Manufacturer: {Manufacturer}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Pixel Density: {PixelDensity} ppi");

            return info.ToString();
        }
    }
}
