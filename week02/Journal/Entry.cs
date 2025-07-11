using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}\n");
    }

    public string FormatForFile()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry ParseFromFile(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2]) { _date = parts[0]};
    }
}
