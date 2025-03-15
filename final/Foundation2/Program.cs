using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address usAddress = new Address("123 Main St", "Seattle", "WA", "98101", "USA");
        Address canadaAddress = new Address("456 Maple Ave", "Toronto", "ON", "M5V 2L3", "Canada");
        Address ukAddress = new Address("789 Oxford St", "London", "Greater London", "W1D 1BS", "UK");

        // Create customers
        Customer customer1 = new Customer("John Doe", usAddress);
        Customer customer2 = new Customer("Jane Smith", canadaAddress);
        Customer customer3 = new Customer("David Johnson", ukAddress);

        // Create products
        Product product1 = new Product("Laptop", "LP001", 999.99, 1);
        Product product2 = new Product("Mouse", "MS001", 24.99, 2);
        Product product3 = new Product("Keyboard", "KB001", 59.99, 1);
        Product product4 = new Product("Monitor", "MN001", 249.99, 1);
        Product product5 = new Product("Headphones", "HP001", 89.99, 1);
        Product product6 = new Product("Tablet", "TB001", 399.99, 1);
        Product product7 = new Product("Printer", "PR001", 199.99, 1);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Order order3 = new Order(customer3);
        order3.AddProduct(product6);
        order3.AddProduct(product7);
        order3.AddProduct(product2);

        // Display order information
        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
        DisplayOrderInfo(order3);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("===== ORDER DETAILS =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine("\nTotal: $" + order.GetTotal());
        Console.WriteLine("========================\n");
    }
}
    