namespace DesignPatternsImplementation.Creationals.FactoryMethod.Products;
public class Train : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by train...");
    }
}