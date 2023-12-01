using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

class Order
{
    private Customer _customer {get; }
    private List<Product> Products {get; }
    public Order(Customer customer, List<Product> products)
    {   
        _customer = customer;
        Products = products;
    }
    public double CalculateTotal()
    {
        double _total = 0;
        foreach (Product product in Products)
        {
            _total += product.CalculatePrice();
        }

        double shippingCost = _customer.IsUSACustomer() ? 5:35;
        return _total + shippingCost;
    }
    public string GetPackingLable()
    {
        return string.Join("\n", Products.ConvertAll(product => product.GetProductInfo()));
    }
    public string GetShippingLable()
    {
        return $"Customer: {_customer.GetName()}\nAddress:\n{_customer.GetFullAddress()}";
    }
}
