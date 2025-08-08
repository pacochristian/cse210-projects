public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override int RecordEvent()
    {
        _isCompleted = true;
        return _points;
    }

    public override string Display()
    {
        return $"[{(_isCompleted ? "X" : " ")}] {_name} ({_description})";
    }
}