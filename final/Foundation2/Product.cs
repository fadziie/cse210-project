class Product
{
    private string _name;
    private string _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string Name { get { return _name; } }
    public string Id { get { return _id; } }
    public decimal Price { get { return _price * _quantity; } }
}