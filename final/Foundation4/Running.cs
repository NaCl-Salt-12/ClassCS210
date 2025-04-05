public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes, "Running")
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = CalculateSpeed();
        return speed;
    }

    public override double GetPace()
    {
        double pace = CalculatePace();
        return pace;
    }

    private double CalculateSpeed()
    {
        return _distance / _minutes * 60; // Speed in mph
    }
    private double CalculatePace()
    {
        return _minutes / _distance; // Pace in min/mile
    }
}