using System;

namespace PrototypePattern
{
    // Prototype interface for cloning
    public interface IShape : ICloneable
    {
        string GetDetails();
    }

    // Concrete Prototype: Circle
    public class Circle : IShape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        // Clone method from ICloneable interface
        public object Clone()
        {
            return new Circle(this.Radius); // shallow copy, deep copy not needed since int is a value type
        }

        public string GetDetails()
        {
            return $"Circle with Radius: {Radius}";
        }
    }

    // Concrete Prototype: Square
    public class Square : IShape
    {
        public int SideLength { get; set; }

        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        // Clone method from ICloneable interface
        public object Clone()
        {
            return new Square(this.SideLength);
        }

        public string GetDetails()
        {
            return $"Square with Side Length: {SideLength}";
        }
    }

    // Client code
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating a Circle prototype
            Circle originalCircle = new Circle(5);
            Console.WriteLine("Original: " + originalCircle.GetDetails());

            // Cloning the Circle
            Circle clonedCircle = (Circle)originalCircle.Clone();
            Console.WriteLine("Cloned: " + clonedCircle.GetDetails());

            // Creating a Square prototype
            Square originalSquare = new Square(10);
            Console.WriteLine("Original: " + originalSquare.GetDetails());

            // Cloning the Square
            Square clonedSquare = (Square)originalSquare.Clone();
            Console.WriteLine("Cloned: " + clonedSquare.GetDetails());

            // Modifying the cloned object
            clonedCircle.Radius = 8;
            Console.WriteLine("Modified Cloned Circle: " + clonedCircle.GetDetails());
            Console.WriteLine("Original Circle after modification: " + originalCircle.GetDetails());
        }
    }
}
