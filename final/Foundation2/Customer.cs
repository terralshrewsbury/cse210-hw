class Customer
{
    private string _name {get; }
    private Address _address {get; }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public bool IsUSACustomer()
    {
        return _address.IsUSA();
    }
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
}
