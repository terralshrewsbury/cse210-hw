class Running : Activity
{
    private double _distance;
    public Running (DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this._distance=distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} -Distance: {_distance:f2} miles, Speed: {GetSpeed():f2} mph, Pace: {GetPace():f2} min per mile";
    }
}
