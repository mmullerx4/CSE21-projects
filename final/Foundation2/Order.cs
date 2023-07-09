using System;

class Order
{
    private List<Product> custProducts = new List<Product>();//contain a list of products per custoemr
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public int calcTotalCost() //sum of products + shipping... if USA $5 and other $35
    {
        foreach (Order in orders)
        {
            return
        }
    }

    public string GetPackList() //name of product and id for each
    {
        foreach (Order in orders)
        {
            return 
        }
    }

    public string GetShipLabel() //name & address of customer
    {
        foreach (Order in orders)
        {
            
        }
        
    }

    public void addProduct(Product product)
    {
        custProducts.Add(product);

    }


}