public class CheckListGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        return _currentCount >= _targetCount ? _points + _bonus : _points;
    }
    
    public override string Display()
    {
        return $"[ ] {_name} ({_description}) - {_currentCount}/{_targetCount} completed";
    }
}