class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, Address address, string rsvpEmail) : base(title, description, date, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP: {_rsvpEmail}";
    }
}