public class Assignment
{
    private String _studentName;
    private String _topic;

    // constructor
    public Assignment(String studentName, String topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // get summury
    public string GetSummary()
    {
        return $"{_studentName}-{_topic}.";
    }
    
    
}