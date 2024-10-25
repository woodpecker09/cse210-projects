using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        shapes.Add(new Square(2,"blue"));
        shapes.Add(new Rectangle(2,3,"green"));
        shapes.Add(new Circle(3,"black"));
        
        foreach (Shape shape in shapes)
        {    
            Console.WriteLine($"color = {shape.GetColor()} area = {shape.GetArea()}");
        }
    }
}