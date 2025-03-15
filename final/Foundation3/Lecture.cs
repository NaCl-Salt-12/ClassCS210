public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;

    public Lecture(string title, string description, DateOnly date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetDetails()
    {
        return $"{GetFull()}\n- {_speaker}\n- {_capacity}";
    }
}