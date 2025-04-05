public abstract class Activity
{
    private string _date;
    protected int _minutes;
    private string _activityType;

    public Activity(string date, int minutes, string activityType)
    {
        _date = date;
        _minutes = minutes;
        _activityType = activityType;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void GetSummary()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Activity Type: {_activityType}");
        Console.WriteLine($"minutes: {_minutes} minutes");
        Console.WriteLine($"Distance: {GetDistance()} miles");
        Console.WriteLine($"Speed: {GetSpeed()} mph");
        Console.WriteLine($"Pace: {GetPace()} min/mile");
    }
}