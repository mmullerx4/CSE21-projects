using System;

class Customer
{
    private string _custName;
    private Address _custAddress;


    public Customer(string custName, Address custAddress)
    {
        _custName = custName;
        _custAddress = custAddress;

    }

    public bool GetIsUSA() //call a method on the address to find
    {
        
    }
    
}