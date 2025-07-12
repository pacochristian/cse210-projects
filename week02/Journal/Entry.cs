using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    //creativity
    public string _moodEmoji;
    public List<string> _tags;
    public Entry(string prompt, string response, string moodEmoji = "😐", List<string> tags = null)
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _response = response;

        //creativity
        _moodEmoji = moodEmoji;
        _tags = tags ?? new List<string> { "general" };

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}\n");

        //creativity
        Console.WriteLine($"😌'Mood: {_moodEmoji}");
        Console.WriteLine($"🏷 Tags: {string.Join(",", _tags)}");
    }

    public string FormatForFile()
    {
        return $"{_date}|{_prompt}|{_response}|{_moodEmoji}|{string.Join(",", _tags)}";
    }

    public static Entry ParseFromFile(string line)
    {
        string[] parts = line.Split('|');
        // return new Entry(parts[1], parts[2]) { _date = parts[0] };

        //creativity
        string mood = parts.Length > 3 ? parts[3] : "😐";
        List<string> tags = parts.Length > 4 ? new List<string>(parts[4].Split(',')) : new List<string>();
        var entry = new Entry(parts[1], parts[2], mood, tags);
        entry._date = parts[0];
        return entry;
    }
}
