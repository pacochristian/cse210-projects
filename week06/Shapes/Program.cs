using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        List<Shape> shapes = new List<Shape>
        {
            new Circle("Red", 5),
            new Rectangle("Blue", 4, 6),
            new Square("Green", 3)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
        }
    }
}