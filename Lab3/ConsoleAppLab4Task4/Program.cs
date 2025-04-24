using Composite;
using Composite.Strategy;

class Program
{
    static void Main()
    {
        Image image = new Image("https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Trou_au_Natron_caldera_satellite_photo.jpg/1280px-Trou_au_Natron_caldera_satellite_photo.jpg");
        image.LoadImage();
        Console.WriteLine(image.OuterHtml());
        Console.WriteLine();
        
        image.Href = "https://broken-link.com/image.jpg";
        image.LoadImage();
        Console.WriteLine(image.OuterHtml());
        Console.WriteLine();

        image.Href = @"..\..\..\images\1.jpg";
        image.LoadImage();
        Console.WriteLine(image.OuterHtml());
    }
}