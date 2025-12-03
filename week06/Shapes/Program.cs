using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(5.0, "Red"));
        shapes.Add(new Rectangle(4.0, 6.0, "Blue"));
        shapes.Add(new Circle(10, "Black"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}