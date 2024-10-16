using System;

namespace DotNet_Design_Patterns.Chapter3.FactoryMethod
{
    // Product Interface
    public abstract class Car
    {
        public abstract void Assemble();
    }

    // Concrete Products
    public class FerrariPetrol : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Ferrari petrol car assembled.");
        }
    }

    public class FerrariDiesel : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Ferrari diesel car assembled.");
        }
    }

    public class VolkswagenPetrol : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Volkswagen petrol car assembled.");
        }
    }

    public class VolkswagenDiesel : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Volkswagen diesel car assembled.");
        }
    }

    // Creator (Factory Method)
    public abstract class CarFactory
    {
        public abstract Car CreateCar();
    }

    // Concrete Creators
    public class FerrariPetrolFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new FerrariPetrol();
        }
    }

    public class FerrariDieselFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new FerrariDiesel();
        }
    }

    public class VolkswagenPetrolFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new VolkswagenPetrol();
        }
    }

    public class VolkswagenDieselFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new VolkswagenDiesel();
        }
    }

    // Client Code
    public class Client
    {
        private readonly CarFactory factory;

        public Client(CarFactory factory)
        {
            this.factory = factory;
        }

        public void AssembleCar()
        {
            Car car = factory.CreateCar();
            car.Assemble();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CarFactory ferrariPetrolFactory = new FerrariPetrolFactory();
            Client client1 = new Client(ferrariPetrolFactory);
            client1.AssembleCar();

            CarFactory volkswagenDieselFactory = new VolkswagenDieselFactory();
            Client client2 = new Client(volkswagenDieselFactory);
            client2.AssembleCar();
        }
    }
}
