public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes, "Cycling")
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _minutes / 60; // Convert to miles
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
        return _speed; // Speed in mph
    }

    private double CalculatePace()
    {
        return 60 / _speed; // Pace in min/mile
    }
}