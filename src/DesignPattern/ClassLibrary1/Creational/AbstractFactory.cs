// Abstract Factory
interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

// Concrete Factory 1
class WindowsFactory : IUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}

// Concrete Factory 2
class MacFactory : IUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}

// Abstract Product A
interface IButton
{
    void Render();
}

// Abstract Product B
interface ICheckbox
{
    void Render();
}

// Concrete Product A1
class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Windows Button");
}

// Concrete Product B1
class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering Windows Checkbox");
}

// Client
class Program
{
    static void Main()
    {
        IUIFactory factory = new WindowsFactory();
        IButton button = factory.CreateButton();
        button.Render();
    }
}
