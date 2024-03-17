namespace DesignPatternsImplementation.Creationals.FactoryMethod.Products;
public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by truck...");
    }
}
