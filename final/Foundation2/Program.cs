using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Product product1 = new Product("Sugar", "P1", 20, 1);
        Product product2 = new Product("Rice", "P2", 30, 2);

        Customer Customer = new Customer("John Doe", new Address("430 Main St", "Cityville", "CA", "US"));

        Order Order = new Order(new List<Product> { product1, product2 }, Customer);

        Console.WriteLine("Packaging Label:");
        Console.WriteLine(Order.GetPackagingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(Order.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${Order.CalculateTotalCost()}");
    }
}