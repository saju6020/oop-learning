﻿class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }

    public void ShowMessage() => Console.WriteLine("Single instance accessed.");
}

class Program
{
    static void Main()
    {
        Singleton singleton = Singleton.Instance;
        singleton.ShowMessage();
    }
}
