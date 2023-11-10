using System;

class Program
{    static void Main(string[] args)
    {
        Square a = new Square();
        a.SetShapeName("square");
        a.SetColor("Red");
        a.SetSide(41);

        Rectangle b = new Rectangle();
        b.SetShapeName("rectangel");
        b.SetColor("White");
        b.SetWidth(2);
        b.SetLength(4);

        Circle c = new Circle();
        c.SetShapeName("circle");
        c.SetColor("Blue");
        c.SetRadius(2.5);
        
        List<Shape> Shapes = new List<Shape>();
        Shapes.Add(a);
        Shapes.Add(b);
        Shapes.Add(c);

        foreach (Shape shape in Shapes)
        {
            double _area = shape.GetArea();
            string _shapeName = shape.GetShapeName();
            string _color= shape.GetColor();
            Console.WriteLine($"{_shapeName} has and area of {_area}ft^2, and is the {_color} .");
        }
    }
}