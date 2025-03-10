using AbstractFactory.Products.Ebooks;
using AbstractFactory.Products.Laptops;
using AbstractFactory.Products.Netbooks;
using AbstractFactory.Products.Smartphones;

namespace AbstractFactory.Creators
{
    public interface IDeviceCreator
    {
        ILaptop CreateLaptop();
        INetbook CreateNetbook();
        IEbook CreateEbook();
        ISmartphone CreateSmartphone();
    }
}
