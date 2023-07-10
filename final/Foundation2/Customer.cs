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
    
    public void GetNameAndAddress()
    {
        Console.WriteLine(_custName);
        _custAddress.fullAddress(); //is already a console.writeline in address
    }

    public bool countryType() //call a method on the address to find countryType
    {
         return _custAddress.GetIsUSA(); 
    
    }

     public void GetAddress()
    {
        _custAddress.fullAddress();
    }

    
}