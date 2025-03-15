public class Outdoor : Event
{
    protected string _weather;

    public Outdoor(string title, string description, DateOnly date, string time, Address address, string type, string weather) : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }
    public string GetDetails()
    {
        return $"{GetFull()}\n- {_weather}";
    }
}