using System;

class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int topNum)
    {
        _topNum = topNum;
        _bottomNum = 1;
    }

    public Fraction(int topNum, int bottomNum)
    {
        _topNum = topNum;
        _bottomNum = bottomNum;
    }

    public int GetTopNum() //we are getting the number and returning it so the type needs to be stated
    {
        return _topNum;
    }
    
    public void SetTopNum(int topNum) //we are giving the value so it needs to be a void type
    {
        _topNum = topNum;
    }

     public int GetBottomNum() //we are getting the number and returning it so the type needs to be stated
    {
        return _bottomNum;
    }
    
    public void SetBottomNum(int bottomNum) //we are giving the value so it needs to be a void type
    {
        _topNum = bottomNum;
    }

    public string GetFractionString()
    {
        return $"{_topNum}/{_bottomNum}";
    }

    public double GetDecimalValue()
    {
        //return _topNum/_bottomNum;
        return (double)_topNum/(double)_bottomNum; //this is typecasting or changing from int to a double
    }
}