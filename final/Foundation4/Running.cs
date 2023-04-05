class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_length / 60.0);
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {_distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
