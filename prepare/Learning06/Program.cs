using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");
        List<Shape> shapes = new List<Shape>();
        Square square = new Square(3, "Yellow");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(4, 5, "Pink");
        shapes.Add(rectangle);

        Circle circle = new Circle(6, "White");
        shapes.Add(circle);

         foreach (Shape shappe in shapes)
        {
            // Show the GetColor method from the base class
            string color = shappe.GetColor();

            // Show the GetArea method for each type of shape.
            double area = shappe.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}