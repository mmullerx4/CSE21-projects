using System;

class Rectangle : Shape
{
    private float _side1;
    private float _side2;


    public Rectangle(string color, float side1, float side2) : base(color)//require 2 arguments: a value for each attribute in math class
    {
        _side1 = side1;
        _side2 = side2;
    }

    public override float GetArea()
    {
        return _side1 * _side2;
    }

}