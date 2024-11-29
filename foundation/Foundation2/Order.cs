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