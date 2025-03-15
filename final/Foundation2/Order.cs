using System.Dynamic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.getPrice() * product.getQuantity();
        }
        if (_customer.IsDomestic() == true)
        {
            total += 5.0;
        }
        else if (_customer.IsDomestic() == false)
        {
            total += 35.0;
        }
        return total;
    }
    public string GetPackLabel()
    {
        string packlabel = "";
        foreach(Product product in _products)
        {
            packlabel += $"\n{product.getName()} - {product.getId()}";
        }
        return packlabel;   
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetSummary()}";
    }
}