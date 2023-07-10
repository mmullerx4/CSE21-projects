using System;

class Order
{
    private List<Product> custProducts = new List<Product>();//contain a list of products per custoemr
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void calcTotalCost() //sum of products + shipping... if USA $5 and other $35
    {
        double totalCost = 0.0;
        double prodTotal = 0;
        double shipping;
        
        foreach(Product prodPrice in custProducts) //declare data type first
        {
            prodTotal = prodPrice.calcQtyPrice(); 
            totalCost += prodTotal;  
            
        }

        if (_customer.countryType() == true) //the customer attribute in this file has the address
            {
                shipping = 5;
                
            }
            else
            {
                shipping = 35;
            }
        totalCost += shipping;
        Console.WriteLine($"Shipping {shipping}");
        Console.WriteLine($"Total ${totalCost}");
        
    }

    public void displayPackList() //name of product name and id for each
    {
        foreach(Product product in custProducts) //the type of list is Product
        {
            Console.WriteLine(product.GetNameAndId());
        }

        
    }

    public void displayShippingLabel() //name & address of customer
    {
        _customer.GetNameAndAddress(); //just calling the display

        
    }

   
    public void addProduct(Product product) //making accessible for main on adding products
    {
        custProducts.Add(product);

    }




}