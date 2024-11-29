using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        // Create some sample customers and addresses
        Address address1 = new Address("143 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Joseph Max", address1);
        // Create some sample products
        Product product1 = new Product(101, "Laptop", 1000.00m, 1);
        // Create orders and add products to them
        Order order1 = new Order(1, customer1);
        order1.AddProduct(product1);
         // Display details for each order
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Price for Order 1: ${order1.TotalPrice()}\n");

         // Create some sample customers and addresses
        Address address2 = new Address("241 s 49th st", "Philadelphia", "PA", "USA");
        Customer customer2 = new Customer("Vladimir Jean", address2);
        // Create some sample products
        Product product2 = new Product(180, "Phone", 500.00m, 5);
        // Create orders and add products to them
        Order order2 = new Order(2, customer2);
        order2.AddProduct(product2);
        // Display details for each order
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Price for Order 2: ${order2.TotalPrice()}\n");

        // Create some sample customers and addresses
        Address address3 = new Address("21  Solonmenos", "Peguy Ville", "PV", "Haiti");
        Customer customer3 = new Customer("Djimy Francillon", address3);
        // Create some sample products
        Product product3 = new Product(101, "Laptop", 1000.00m, 1);
        // Create orders and add products to them
        // Create orders and add products to them
        Order order3 = new Order(3, customer3);
        order3.AddProduct(product3);
        // Display details for each order
        Console.WriteLine(order3.GeneratePackingLabel());
        Console.WriteLine(order3.GenerateShippingLabel());
        Console.WriteLine($"Total Price for Order 3: ${order3.TotalPrice()}\n");

    }
}






