using AbstractFactory.Products.Ebooks;
using AbstractFactory.Products.Laptops;
using AbstractFactory.Products.Netbooks;
using AbstractFactory.Products.Smartphones;

namespace AbstractFactory.Creators
{
    public class BalaxyCreator : IDeviceCreator
    {
        public IEbook CreateEbook()
        {
            Console.WriteLine("Assembling Balaxy Ebook...");
            return new BalaxyEbook("BalaxyRead 3", 340);
        }

        public ILaptop CreateLaptop()
        {
            Console.WriteLine("Assembling Balaxy Laptop...");
            return new BalaxyLaptop("BalaxyBook 15", 14.4f);
        }

        public INetbook CreateNetbook()
        {
            Console.WriteLine("Assembling Balaxy Netbook...");
            return new BalaxyNetbook("BalaxyNet 2", 40);
        }

        public ISmartphone CreateSmartphone()
        {
            Console.WriteLine("Assembling Balaxy Smartphone...");
            return new BalaxySmartphone("Balaxy S20", "LTPO");
        }
    }
}
