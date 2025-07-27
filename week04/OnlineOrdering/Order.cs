public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double GetTotalPrice()
    {
        double total = products.Sum(product => product.GetTotalPrice());
        double shipping = customer.IsUSA() ? 5 : 35;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        return string.Join(", ", products.Select(product => product.GetPackingInfo()));
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()} - {customer.GetAddress().GetFullAddress()}";
    }
}
