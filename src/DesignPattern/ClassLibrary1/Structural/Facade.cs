class SubSystem1
{
    public void Operation1() => Console.WriteLine("SubSystem1: Operation1");
}

class SubSystem2
{
    public void Operation2() => Console.WriteLine("SubSystem2: Operation2");
}

class Facade
{
    private SubSystem1 _subsystem1;
    private SubSystem2 _subsystem2;

    public Facade()
    {
        _subsystem1 = new SubSystem1();
        _subsystem2 = new SubSystem2();
    }

    public void PerformOperation()
    {
        _subsystem1.Operation1();
        _subsystem2.Operation2();
    }
}

// Client
class Program
{
    static void Main()
    {
        Facade facade = new Facade();
        facade.PerformOperation();
    }
}
