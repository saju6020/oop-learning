interface ICommand
{
    void Execute();
}

class Light
{
    public void TurnOn() => Console.WriteLine("Light is ON");
    public void TurnOff() => Console.WriteLine("Light is OFF");
}

class TurnOnCommand : ICommand
{
    private Light _light;

    public TurnOnCommand(Light light) => _light = light;

    public void Execute() => _light.TurnOn();
}

class TurnOffCommand : ICommand
{
    private Light _light;

    public TurnOffCommand(Light light) => _light = light;

    public void Execute() => _light.TurnOff();
}

// Client
class Program
{
    static void Main()
    {
        Light livingRoomLight = new Light();

        ICommand turnOn = new TurnOnCommand(livingRoomLight);
        ICommand turnOff = new TurnOffCommand(livingRoomLight);

        turnOn.Execute();
        turnOff.Execute();
    }
}
