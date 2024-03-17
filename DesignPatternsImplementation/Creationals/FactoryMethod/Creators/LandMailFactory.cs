using DesignPatternsImplementation.Creationals.FactoryMethod.Products;

namespace DesignPatternsImplementation.Creationals.FactoryMethod.Creators;
public class LandMailFactory : ITransportFactory
{
	public ITransport CreateTransport(string choice)
	{
		if (choice.ToLower() == "truck")
		{
			return new Truck();
		}
		else if (choice.ToLower() == "train")
		{
			return new Train();
		}
		else
		{
			throw new ArgumentException("Invalid means of transport.");
		}    
	}
}
