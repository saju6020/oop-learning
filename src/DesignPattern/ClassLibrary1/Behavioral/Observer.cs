interface IObserver
{
    void Update(string availability);
}

class Customer : IObserver
{
    public string Name { get; set; }

    public Customer(string name) => Name = name;

    public void Update(string availability)
    {
        Console.WriteLine($"Hello {Name}, Product is now {availability}");
    }
}

interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

class Product : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    public string Name { get; set; }
    public string Availability { get; set; }

    public Product(string name) => Name = name;

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);

    public void Notify()
    {
        foreach (var observer in _observers)
            observer.Update(Availability);
    }

    public void SetAvailability(string availability)
    {
        Availability = availability;
        Notify();
    }
}

// Client
class Program
{
    static void Main()
    {
        Product product = new Product("Laptop");
        Customer customer1 = new Customer("John");
        Customer customer2 = new Customer("Sarah");

        product.Attach(customer1);
        product.Attach(customer2);

        product.SetAvailability("Available");
    }
}
