abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract Shape Clone();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }
}

// Client
class Program
{
    static void Main()
    {
        var rect1 = new Rectangle { X = 10, Y = 20, Width = 30, Height = 40 };
        var rect2 = (Rectangle)rect1.Clone();
        Console.WriteLine($"Rectangle cloned: X={rect2.X}, Y={rect2.Y}, Width={rect2.Width}, Height={rect2.Height}");
    }
}
