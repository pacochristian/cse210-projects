using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("900 Main St", "California", "IL", "USA");
        Customer customer = new Customer("Paco Dude", address1);
        List<Product> products = new List<Product>
        {
            new Product("Widget", "W123", 19.99, 2),
            new Product("Gadget", "G456", 29.99, 1)
        };
        Order order = new Order(products, customer);
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");

        Address address2 = new Address("300 sopht street", "New York", "NY", "USA");
        Customer customer2 = new Customer("Jane Doe", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Thingamajig", "T789", 15.99, 3),
            new Product("Doodad", "D012", 25.50, 1)
        };
        Order order2 = new Order(products2, customer2);
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}