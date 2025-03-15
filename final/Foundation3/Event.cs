public class Event
{
    protected string _title;
    protected string _description;
    protected DateOnly _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    public Event(string title, string description, DateOnly date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }
    public string GetStandard()
    {
        return $"{_title}\n- {_date}\n- {_time}\n- {_address.GetAddress()}\n- {_description}";
    }
    public string GetFull()
    {
        return $"{_title}\n- {_date}\n- {_time}\n- {_address.GetAddress()}\n- {_description}\n- {_type}";
    }
    public string GetShort()
    {
        return $"{_title}\n- {_date}\n- {_type}";
    }
}