class LapSwimming : Activity
{
    private int _laps;

    public LapSwimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_length / 60.0);
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
