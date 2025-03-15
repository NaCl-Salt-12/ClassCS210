public class Reception : Event
{
    protected string _email;

    public Reception(string title, string description, DateOnly date, string time, Address address, string type, string email) : base(title, description, date, time, address, type)
    {
        _email = email;
    }
    public string GetDetails()
    {
        return $"{GetFull()}\n- {_email}";
    }
}