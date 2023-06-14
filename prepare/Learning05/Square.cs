using System;

class Square : Shape
{
    private float _side;
    public Square(string color, float side) : base(color)//need only the color from the base
    {
        _side = side;
    }

    public override float GetArea()
    {
        return _side * 4;
        
    }

}