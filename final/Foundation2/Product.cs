public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        this.quantity = quantity;
    }
    public string getName()
    {
        return _name;
    }
    public string getId()
    {
        return _id;
    }
    public double getPrice()
    {
        return _price;
    }
    public int getQuantity()
    {
        return quantity;
    }
}