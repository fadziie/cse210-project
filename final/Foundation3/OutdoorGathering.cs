class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, Address address) : base(title, description, date, address)
    {
    }

    public OutdoorGathering(string title, string description, DateTime date, Address address, string weatherStatement) : base(title, description, date, address)
    {
        _weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather: {_weatherStatement}";
    }
}

