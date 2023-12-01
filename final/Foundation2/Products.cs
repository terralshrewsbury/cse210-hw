class Product
{
    private string _productName {get; }
    private string _productId {get; }
    private double _price {get; }
    private int _quantity {get; }
    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;

    }
    public double CalculatePrice()
    {

        return _price*_quantity;
    }
    public string GetProductInfo()
    {
        
        return $"{_productName} (ID: {_productId}) - Quantity: {_quantity})";
    }

}
