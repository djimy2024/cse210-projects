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

