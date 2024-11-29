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
        Console.WriteLine($"Total Price for Order 1: ${order3.TotalPrice()}\n");

    }
}

class Product
{
 private int _productId;
 private string _name;
 private decimal _price;
 private int _quantity;

 public Product(int productId, string name, decimal price, int quantity)
 {
    _productId = productId;
    _name = name;
    _price = price;
    _quantity = quantity;
 }

 public decimal GetTotalCost()
 {
    return _price * _quantity;
 }

 public override string ToString()
    {
        return $"{_name} (ID: {_productId})";
    }

}


class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

     // Method to return the full address as a string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }

     public bool IsInUSA()// check if the address is in USA.
    {
        return _country == "USA";
    }
}

class Customer
{
    public string _name;
    public Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

      // Method to return customer name
    public string GetName()
    {
        return _name;
    }

     public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to return customer's address as a string
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

}


class Order
{
 private int _orderId;
 Customer _customer;
 private decimal _shippingCost;

    List<Product> products = new List<Product>();
    List<Customer> customers = new List<Customer>();

    public Order(int orderId, Customer customer)
    {
        _orderId = orderId;
        _customer = customer;
        _shippingCost = customer.IsInUSA() ? 5m : 35m;
    }

    public void AddProduct(Product product)// Add a product to the order.
    {
      products.Add(product);
    }

    public decimal TotalPrice()
    {
        decimal Total = 0;
        foreach(Product product in products)
        {
            Total += product.GetTotalCost();
        }
        Total += _shippingCost;
        return Total;

    }

    // Generate the packing label for the order
    public string GeneratePackingLabel()
    {
        string label = $"Packing Label for Order {_orderId}:\n";
        foreach (Product product in products)
        {
            label += $"{product.ToString()} - Quantity: {product.GetTotalCost() / product.GetTotalCost()}\n";
        }
        return label;
    }

    // Generate the shipping label for the order
    public string GenerateShippingLabel()
    {
        return $"Shipping Label for Order {_orderId}:\nTo: {_customer.GetName()}\n{_customer.GetAddress()}";
    }

}