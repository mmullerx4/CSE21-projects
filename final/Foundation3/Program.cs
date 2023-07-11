using System;

//Inheritance
//derived (child) classes can inherit code from base (parent) class
//and change to a variation using virtual on base and an overrride on the derived class
//This program helps to organize market events throughout the world
//track each event and produce marketing material to distribute on social media

//create one event for each type and set values

class Program
{
    //Address address1 = new Address("10 Sweet", "Pinckney", "MI", "USA");
    //Customer customer1 = new Customer("Bill Smith", address1);
    //Product product1 = new Product("wrench", 01, 20.00, 2);
    //Product product2 = new Product("hammer", 02, 15.00, 3);
    
    //Order order1 = new Order(customer1);

    //order1.addProduct(product1);
    //order1.addProduct(product2);
    //order1.displayPackList();
    //order1.displayShippingLabel();
    //order1.calcTotalCost();
    //Console.WriteLine();
    static void Main(string[] args)
    {

        //Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
        Event event001 = new Event("Screen Time Effects", "How screentime effects us", "01/05/24", "2:00 p.m.", "101 Event Way, Birmingham MI"); //"int" not needed
        Address address1 = new Address("10 Sweet", "Pinckney", "MI", "USA");
        Lecture lecture01 = new Lecture();



        //Event event002 = new Event();
        Reception reception01 = new Reception();



        Outdoor outdoor01 = new Outdoor();
    }
}