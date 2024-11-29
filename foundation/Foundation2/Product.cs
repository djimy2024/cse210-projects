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
