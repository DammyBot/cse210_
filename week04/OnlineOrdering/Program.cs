using System;

class Program
{
    static void Main(string[] args)
    {
        // ----- Order 1: Customer in USA -----
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Alice Johnson", addr1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-100", 25.99m, 2));
        order1.AddProduct(new Product("Keyboard", "KB-200", 45.50m, 1));
        order1.AddProduct(new Product("USB Cable", "USB-01", 5.00m, 3));

        // ----- Order 2: Customer outside USA -----
        Address addr2 = new Address("456 Elm Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Mohammed Ade", addr2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bluetooth Speaker", "BS-500", 55.00m, 1));
        order2.AddProduct(new Product("Phone Case", "PC-321", 12.75m, 2));

        // Display results for both orders
        Console.WriteLine("=== Order 1 Summary ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("=== Order 2 Summary ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}\n");
    }
}
