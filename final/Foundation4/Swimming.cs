public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int minutes, double laps) : base(date, minutes, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 164.042 / 5280; // Convert to miles
    }

    public override double GetSpeed()
    {
        return CalculateSpeed();
    }

    public override double GetPace()
    {
        return CalculatePace();
    }

    private double CalculateSpeed()
    {
        return GetDistance() / _minutes; // Speed in mph
    }

    private double CalculatePace()
    {
        return _minutes / GetDistance(); // Pace in min/mile
    }
}