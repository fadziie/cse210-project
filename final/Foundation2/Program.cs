using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two customers
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("456 Broadway", "Another Town", "NY", "USA"));

        // Create some products
        Product product1 = new Product("Widget", "W123", 10.0m, 2);
        Product product2 = new Product("Gizmo", "G456", 5.0m, 3);
        Product product3 = new Product("Thing", "T789", 20.0m, 1);

        // Create two orders with some products
        Order order1 = new Order(customer1, new Product[] { product1, product2 });
        Order order2 = new Order(customer2, new Product[] { product2, product3 });
        // Print the packing labels, shipping labels, and total prices for the orders
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: {order1.GetTotalPrice():C}");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total price: {order2.GetTotalPrice():C}");
    }
}

