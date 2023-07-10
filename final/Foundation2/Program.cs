using System;

//Encapsulation - ensuring data has little accesability using private, protected, public
//Product ordering system
//Products, customers, packing lables, shipping labels
//and compute prices for billing

//create two orders with 2-3 products each
//call methods for packing label, shipping label, total price and display
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("10 Sweet", "Pinckney", "MI", "USA");
        Customer customer1 = new Customer("Bill Smith", address1);
        
        Product product1 = new Product("wrench", 01, 20.00, 2);
        Product product2 = new Product("hammer", 02, 15.00, 3);
        
        
        Order order1 = new Order(customer1);

        order1.addProduct(product1);
        order1.addProduct(product2);
        order1.displayPackList();
        order1.displayShippingLabel();
        order1.calcTotalCost();
        Console.WriteLine();

        Address address2 = new Address("20 Jellybean Way", "Fowlerville", "Alberta", "Canada");
        Customer customer2 = new Customer("Jack Jones", address2);
        
        Product product3 = new Product("flathead", 03, 20.20, 2);
        Product product4 = new Product("mallet", 04, 25.00, 3);
       
        
        Order order2 = new Order(customer2);

        order2.addProduct(product3);
        order2.addProduct(product4);
        order2.displayPackList();
        order2.displayShippingLabel();
        order2.calcTotalCost();
        Console.WriteLine();
        
    }
}