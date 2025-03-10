using AbstractFactory.Products.Ebooks;
using AbstractFactory.Products.Laptops;
using AbstractFactory.Products.Netbooks;
using AbstractFactory.Products.Smartphones;

namespace AbstractFactory.Creators
{
    public class IproneCreator : IDeviceCreator
    {
        public IEbook CreateEbook()
        {
            Console.WriteLine("Assemblying Iprone Ebook...");
            return new IproneEbook("PocketBook 618", 300);
        }

        public ILaptop CreateLaptop()
        {
            Console.WriteLine("Assemblying Iprone Laptop...");
            return new IproneLaptop("MacProne 11", 11.6f);
        }

        public INetbook CreateNetbook()
        {
            Console.WriteLine("Assemblying Iprone Netbook...");
            return new IproneNetbook("NetProne 10", 50);
        }

        public ISmartphone CreateSmartphone()
        {
            Console.WriteLine("Assemblying Iprone Smartphone...");
            return new IproneSmartphone("SmartProne 12", "OLED");
        }
    }
}
