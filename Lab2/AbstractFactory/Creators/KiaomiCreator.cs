using AbstractFactory.Products.Ebooks;
using AbstractFactory.Products.Laptops;
using AbstractFactory.Products.Netbooks;
using AbstractFactory.Products.Smartphones;

namespace AbstractFactory.Creators
{
    public class KiaomiCreator : IDeviceCreator
    {
        public IEbook CreateEbook()
        {
            Console.WriteLine("Assemblying Kiaomi Ebook...");
            return new KiaomiEbook("Kiaomi 618", 300);
        }

        public ILaptop CreateLaptop()
        {
            Console.WriteLine("Assemblying Kiaomi Laptop...");
            return new KiaomiLaptop("Kiaomi 14", 15.6f);
        }

        public INetbook CreateNetbook()
        {
            Console.WriteLine("Assemblying Kiaomi Netbook...");
            return new KiaomiNetbook("NetAir 2", 55);
        }

        public ISmartphone CreateSmartphone()
        {
            Console.WriteLine("Assemblying Kiaomi Smartphone...");
            return new KiaomiSmartphone("Kiaomi 10", "AMOLED");
        }
    }
}
