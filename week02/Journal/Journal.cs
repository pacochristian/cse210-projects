public class Journal
{
    // private Prompter _prompter = new Prompter();
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        // string prompt = _prompter.GetRandomPrompt();
        // Console.WriteLine($"{prompt}");
        // Console.Write("> ");
        // string response = Console.ReadLine();

        // Entry newEntry = new Entry(prompt, response);
        _entries.Add(entry);
        // Console.WriteLine("");
    }

    public void DisplayJournal()
    {
        foreach (Entry i in _entries)
        {
            i.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry i in _entries)
            {
                writer.WriteLine(i.FormatForFile());
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        foreach (string line in File.ReadAllLines(filename))
        {
            _entries.Add(Entry.ParseFromFile(line));
        }
    }
}