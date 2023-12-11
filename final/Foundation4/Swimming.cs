class Swimming : Activity
{
    private int _laps;
    public Swimming (DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this._laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 100;
    }
    public override double GetSpeed()
    {
    return GetDistance() / _minutes * 60;
    }
    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():f2} km, Speed: {GetSpeed():f2} kph, Pace: {GetPace():f2} min per km";
    }
}
