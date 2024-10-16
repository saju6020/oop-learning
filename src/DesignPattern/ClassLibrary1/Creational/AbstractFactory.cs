public abstract class CarFactory
{
    public abstract PetrolCar CreatePetrolCar();
    public abstract DieselCar CreateDieselCar();
}

public class FerrariFactory : CarFactory
{
    public override DieselCar CreateDieselCar()
    {
        return new FerrariDiesel();
    }

    public override PetrolCar CreatePetrolCar()
    {
        return new FerrariPetrol();
    }
}

public class VolkswagenFactory : CarFactory
{
    public override DieselCar CreateDieselCar()
    {
        return new VolkswagenDiesel();
    }

    public override PetrolCar CreatePetrolCar()
    {
        return new VolkswagenPetrol();
    }
}

public abstract class PetrolCar
{
    public abstract void AssembleSeats();
}

public class FerrariPetrol : PetrolCar
{
    public override void AssembleSeats()
    {
        Console.WriteLine("Ferrari petrol car seats assembled.");
    }
}

public class VolkswagenPetrol : PetrolCar
{
    public override void AssembleSeats()
    {
        Console.WriteLine("Volkswagen petrol car seats assembled.");
    }
}

public abstract class DieselCar
{
    public abstract void AssembleDieselEngine();
}

public class FerrariDiesel : DieselCar
{
    public override void AssembleDieselEngine()
    {
        Console.WriteLine("Ferrari diesel engine assembled.");
    }
}

public class VolkswagenDiesel : DieselCar
{
    public override void AssembleDieselEngine()
    {
        Console.WriteLine("Volkswagen diesel engine assembled.");
    }
}

public class Client
{
    private readonly CarFactory factory;

    public Client(CarFactory factory)
    {
        this.factory = factory;
    }

    public void CreatePetrolCar()
    {
        var petrol = factory.CreatePetrolCar();
        petrol.AssembleSeats();
    }

    public void CreateDieselCar()
    {
        var diesel = factory.CreateDieselCar();
        diesel.AssembleDieselEngine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        CarFactory ferrariFactory = new FerrariFactory();
        Client ferrariClient = new Client(ferrariFactory);
        ferrariClient.CreatePetrolCar();
        ferrariClient.CreateDieselCar();

        CarFactory volkswagenFactory = new VolkswagenFactory();
        Client volkswagenClient = new Client(volkswagenFactory);
        volkswagenClient.CreatePetrolCar();
        volkswagenClient.CreateDieselCar();
    }
}