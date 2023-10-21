public class Order
{
    private List<Product> _Products { get; set; }
    private Customer _Customer { get; set; }

    public Order(List<Product> Products, Customer Customer)
    {
        _Products = Products;
        _Customer = Customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalPrice = _Products.Sum(product => product.CalculateTotalPrice());
        decimal shippingCost = _Customer.IsUsCustomer() ? 5 : 35;
        return totalPrice + shippingCost;
    }

    public string GetPackagingLabel()
    {
        return string.Join("\n", _Products.Select(product => $"{product.GetName()} ({product.GetProductId()})"));
    }

    public string GetShippingLabel()
    {
        return $"{_Customer.GetName()}\n{_Customer.GetAddress().GetFullAddress()}";
    }
}
