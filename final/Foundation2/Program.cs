using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address addressUsa = new Address("606 W 1300 N", "Clinton", "Utah", "USA");
        Address addressInternational = new Address("8619 Cavendish Rd", "Cavendish", "PE C0A 1N0", "Canada");

        Customer customer1 = new Customer("Lillie Shrewsbury", addressUsa);
        Customer customer2 = new Customer("Anne of Green Gables", addressInternational);

        Product product1 = new Product("Portable Pickelball Net", "B0C5XKTLD1", 79.99, 1);
        Product product2 = new Product("Heated Rocking camp chair", "B0CJVD2NKJ", 109.99 , 1);
        
        Order order1 = new Order(customer1, new List<Product>{product1, product2});
        Order order2 = new Order(customer2, new List<Product>{product1});

        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLable());
        Console.WriteLine("\nOrder 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLable());
        Console.WriteLine("\nOrder 1 - Total Price:");
        Console.WriteLine($"{order1.CalculateTotal()}");

        Console.WriteLine("\n--------------------------\n");

        Console.WriteLine("Order 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLable());
        Console.WriteLine("\nOrder 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLable());
        Console.WriteLine("\nOrder 2 - Total Price:");
        Console.WriteLine($"{order2.CalculateTotal()}");
        
    }
}       
