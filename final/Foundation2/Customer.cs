public class Customer
{
    private string _Name { get; set; }
    private Address _Address { get; set; }

    public Customer(string Name, Address Address)
    {
        _Name = Name;
        _Address = Address;
    }

    public bool IsUsCustomer()
    {
        return _Address.IsUsAddress();
    }

    public string GetName()
    {
        return _Name;
    }

    public Address GetAddress()
    {
        return _Address;
    }
}