using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Address 
{
    private string _street {get; }
    private string _city {get; }
    private string _state {get; }
    private string _country {get; }

    public Address (string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_country}";
    }
}
