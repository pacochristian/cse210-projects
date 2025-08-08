using System.Security.Cryptography.X509Certificates;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override int RecordEvent()
    {
        return _points;
    }
    public override string Display()
    {
        return $"[ ] {_name} ({_description})";
    }
}