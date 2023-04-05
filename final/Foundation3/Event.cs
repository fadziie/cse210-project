abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    public Event(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }
    public string GetStandardDetails()
    {
        return $"{_title} - {_description}\nDate: {_date.ToShortDateString()} Time: {_date.ToShortTimeString()}\nAddress: {_address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name} - {_title} - {_date.ToShortDateString()}";
    }
}