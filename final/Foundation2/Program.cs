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
        Product product1 = new Product("wrench", 01, 20.00, 2);
        Product product2 = new Product("hammer", 01, 15.00, 3);
        Address address1 = new Address("10 Sweet", "Pinckney", "MI", "USA");
        Customer customer1 = new Customer("Bill Smith", address1);
        Order order1 = new Order(customer1);

        order1.addProduct(product1);
    }
}