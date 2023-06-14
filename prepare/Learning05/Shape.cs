using System;

class Shape 
{
    private string _color;
    private string _shape;
    protected float _area;

    public Shape(string color)  
    {
        _color = color; //constructor setting the color
        
    }

    public void GetColor()
    {
        Console.WriteLine(_color);
    }

    public void GetShape()
    {
        Console.WriteLine(_shape);
    }

    public void SetColor(string color)
    {
        _color = color;
    }

   


    public virtual float GetArea()
    {
        return _area;
        
    }
}