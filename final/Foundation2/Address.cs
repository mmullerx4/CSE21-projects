using System;

class Address{
    private string _streetAddress;
    private string _city;
    private string _provState;
    private string _country;


    public Address(string streetAddress, string city, string provState, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _provState = provState;
        _country = country;
    }

    public bool GetIsUSA()
    {

    }

    public void combineAddress()
    {
        Console.WriteLine("_streetAddress");
        Console.WriteLine($"{_city}, {_provState}");
        Console.WriteLine("_country");
    }
}