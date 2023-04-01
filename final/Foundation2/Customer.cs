class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Name { get { return _name; } }
    public bool IsInUSA { get { return _address.IsInUSA(); } }
    public decimal GetShippingCost()
    {
        return IsInUSA ? 5.0m : 35.0m;
    }
    public string GetAddressString()
    {
        return _address.ToString();
    }
}