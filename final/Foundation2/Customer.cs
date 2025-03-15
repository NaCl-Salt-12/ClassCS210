public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string getAddress()
    {
        return _address.GetAddress();
    }
    public string GetSummary()
    {
        return $"{_name} - {_address.GetAddress()}";
    }
    public bool IsDomestic()
    {
        return _address.IsDometic();
    }
    public string GetName()
    {
        return _name;
    }
}