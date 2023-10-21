public class Address
{
    private string _Street { get; set; }
    private string _City { get; set; }
    private string _State { get; set; }
    private string _Country { get; set; }

    public Address(string Street, string City, string State, string Country)
    {
        _Street = Street;
        _City = City;
        _State = State;
        _Country = Country;
    }

    public bool IsUsAddress()
    {
        return _Country.ToLower() == "us";
    }

    public string GetFullAddress()
    {
        return $"{_Street}, {_City}, {_State}, {_Country}";
    }
}
