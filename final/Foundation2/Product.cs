public class Product
{
    private string _Name { get; set; }
    private string _ProductId { get; set; }
    private decimal _Price { get; set; }
    private int _Quantity { get; set; }

    public Product(string Name, string ProductId, decimal Price, int Quantity)
    {
        _Name = Name;
        _ProductId = ProductId;
        _Price = Price;
        _Quantity = Quantity;
    }

    public decimal CalculateTotalPrice()
    {
        return _Price * _Quantity;
    }

    public string GetName()
    {
        return _Name;
    }

    public string GetProductId()
    {
        return _ProductId;
    }

    public decimal GetPrice()
    {
        return _Price;
    }

    public int GetQuantity()
    {
        return _Quantity;
    }
}