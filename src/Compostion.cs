public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }
}

// Class representing the Tires of a car
public class Tire
{
    public void Inflate()
    {
        Console.WriteLine("Tire inflated.");
    }
}

// Class representing a Car, which "has-a" Engine and Tires (composition)
public class Car
{
    private Engine _engine;
    private Tire _tire;

    // Constructor initializing the engine and tire objects
    public Car()
    {
        _engine = new Engine();
        _tire = new Tire();
    }

    // Method to start the car, which uses the composed Engine and Tire classes
    public void StartCar()
    {
        _tire.Inflate();
        _engine.Start();
        Console.WriteLine("Car started.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Car object and start it
        Car myCar = new Car();
        myCar.StartCar();
    }
}