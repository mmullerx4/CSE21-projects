using System;

class Product{
    private string _prodName;
    private int _prodId;
    private double _prodPrice;
    private double _prodQty;

    public Product(string prodName, int prodId, double prodPrice, double prodQty)
    {
        _prodName = prodName;
        _prodId = prodId;
        _prodPrice = prodPrice;
        _prodQty = prodQty;
    }
    public double calcQtyPrice() //functions start with verb...multiply price * qty
    {
        return _prodPrice * _prodQty;
    }
}