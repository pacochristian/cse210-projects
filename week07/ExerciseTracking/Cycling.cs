public class Cycling : Activity
{
    private double _distance;

    public Cycling(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / (double)GetDuration()) * 60; // Speed in miles per hour
    }
    public override double GetPace()
    {
        return (double)GetDuration() / _distance; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{GetDate()} - Duration: {GetDuration()} minutes, Distance: {_distance} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}