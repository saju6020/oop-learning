using System;

// Base class (Parent class)
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying high in the sky!");
    }
}

// Subclass (Penguin)
public class Penguin : Bird
{
    // Penguins cannot fly, so we'll have to either throw an exception or leave this unimplemented
    public override void Fly()
    {
        throw new NotImplementedException("Penguins can't fly!");
    }
}

