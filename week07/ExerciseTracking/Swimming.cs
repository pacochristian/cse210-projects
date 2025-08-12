public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60; // Speed in yards per minute
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance(); // Pace in minutes per yard
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming {GetDuration()} minutes): Distance {GetDistance():0.0} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km";
    }
}