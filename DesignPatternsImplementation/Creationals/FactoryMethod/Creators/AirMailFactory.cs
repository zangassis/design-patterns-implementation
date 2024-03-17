using DesignPatternsImplementation.Creationals.FactoryMethod.Products;

namespace DesignPatternsImplementation.Creationals.FactoryMethod.Creators;
public class AirMailFactory : ITransportFactory
{
	public ITransport CreateTransport(string choice)
	{
		if(choice == "plane")
			return new Plane();
		else
			throw new ArgumentException("Invalid means of transport.");
	}
}