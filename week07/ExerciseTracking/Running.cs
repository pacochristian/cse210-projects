public class Running : Activity
{
    private double _distanceKm;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distanceKm = distance;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        return (_distanceKm / (double)GetDuration()) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return (double)GetDuration() / _distanceKm; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running {GetDuration()} minutes, Distance: {_distanceKm} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km";
    }
}