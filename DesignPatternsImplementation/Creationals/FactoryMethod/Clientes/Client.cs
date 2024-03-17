using DesignPatternsImplementation.Creationals.FactoryMethod.Creators;
using DesignPatternsImplementation.Creationals.FactoryMethod.Products;

namespace DesignPatternsImplementation.Creationals.FactoryMethod.Clientes;
public class Client
{
   private ITransportFactory _factory;

    public Client(ITransportFactory factory)
    {
        _factory = factory;
    }

    public void SendParcel()
    {
        ITransport transport = _factory.CreateTransport();
        transport.Deliver();
    }
}