using DesignPatternsImplementation.Creationals.FactoryMethod.Products;

namespace DesignPatternsImplementation.Creationals.FactoryMethod.Creators;
public interface ITransportFactory
{
    ITransport CreateTransport(string choice);
}