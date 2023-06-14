using System;

class Program
{
    static void Main(string[] args)
    {
        //Square square = new Square("red", 4); //naming the color, declaring the shape, & the side length for a square

        //square.GetArea(); //calling the method to get the area
        //square.GetColor(); //calling the color method

        List<Shape> shapes = new List<Shape>()
        {
            new Square("red", 4.0f),
            new Rectangle("blue", 3.0f, 4.0f),
            new Circle("green", 4.0f)
        };
       
        //Console.WriteLine(square.GetArea());
        foreach (Shape s in shapes) //calling new variable "s" for each shape in shapes
        {
            s.GetColor();
            s.GetArea();
            Console.WriteLine(s.GetArea());

        }
        
    }
}