interface INotifier
{
    void Send(string message);
}

class Notifier : INotifier
{
    public void Send(string message) => Console.WriteLine("Sending message: " + message);
}

class NotifierDecorator : INotifier
{
    protected INotifier _notifier;

    public NotifierDecorator(INotifier notifier) => _notifier = notifier;

    public virtual void Send(string message) => _notifier.Send(message);
}

class EmailNotifier : NotifierDecorator
{
    public EmailNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine("Sending Email Notification");
    }
}

// Client
class Program
{
    static void Main()
    {
        INotifier notifier = new Notifier();
        INotifier emailNotifier = new EmailNotifier(notifier);
        emailNotifier.Send("Hello World");
    }
}
