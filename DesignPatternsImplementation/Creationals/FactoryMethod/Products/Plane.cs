namespace DesignPatternsImplementation.Creationals.FactoryMethod.Products;
public class Plane : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by plane...");
    }
}
