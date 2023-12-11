class Address
{
    private string _street {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private string _zipcode {get; set;}

    public Address(string street, string city, string state, string zipcode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }
    public override string ToString()
    {
        return $"{_street}, {_city}, {_state} {_zipcode}";
    }
}
