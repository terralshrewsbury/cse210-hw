class Lecture:Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity):base(title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
