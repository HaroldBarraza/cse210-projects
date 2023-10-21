using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Product product1 = new Product("Product 1", "P1", 20, 2);
        Product product2 = new Product("Product 2", "P2", 30, 1);

        Customer Customer = new Customer("John Doe", new Address("123 Main St", "Cityville", "CA", "US"));

        Order Order = new Order(new List<Product> { product1, product2 }, Customer);

        Console.WriteLine("Packaging Label:");
        Console.WriteLine(Order.GetPackagingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(Order.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${Order.CalculateTotalCost()}");
    }
}