class Order
{
    private Customer _customer;
    private Product[] _products;

    public Order(Customer customer, Product[] products)
    {
        _customer = customer;
        _products = products;
    }
     public decimal GetTotalPrice()
    {
        decimal totalPrice = 0m;
        foreach (Product product in _products)
        {
            totalPrice += product.Price;
        }
        totalPrice += _customer.GetShippingCost();
        return totalPrice;
    }
    public string GetPackingLabel()
    {
        string label = $"Packing label for {_customer.Name}:\n";
        foreach (Product product in _products)
        {
            label += $"{product.Name} ({product.Id})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping label for {_customer.Name}:\n{_customer.GetAddressString()}";
    }
}