class Reception:Event
{
    private string _rsvpEmail;
    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail):base(title, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}Type: Reception\nRSVP Email: {_rsvpEmail}";
    }

}
