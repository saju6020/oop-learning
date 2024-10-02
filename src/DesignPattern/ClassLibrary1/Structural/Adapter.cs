// Target
interface ITarget
{
    void Request();
}

// Adaptee
class Adaptee
{
    public void SpecificRequest() => Console.WriteLine("Called SpecificRequest.");
}

// Adapter
class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee) => _adaptee = adaptee;

    public void Request() => _adaptee.SpecificRequest();
}

// Client
class Program
{
    static void Main()
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);
        target.Request();
    }
}
