using System;

class Circle : Shape
{
    private float _radius;


    public Circle(string color, float radius) : base(color)//require 2 arguments: a value for each attribute in math class
    {
        _radius = radius;
    
    }

    public override float GetArea()
    {
        return 3.14f * (_radius * _radius); //add the f for the float number
    }

}