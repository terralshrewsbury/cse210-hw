class Outdoor:Event
{
    private string _weatherStatement;
    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement):base(title, description, date, time, address)
    {
        this._weatherStatement = weatherStatement;
    }
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Outdoor Gathering\nWeather: {_weatherStatement}";
    }
}
