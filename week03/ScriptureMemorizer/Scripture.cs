public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        foreach (string wordText in text.Split(' '))
        {
            words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(words.Count);
            words[index].Hide();
        }

         List<Word> visibleWords = words.Where(w => !w.isHidden()).ToList();
        rand = new Random();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

    }

    public string GetDisplayText()
    {
        string display = reference.GetDisplayText() + "\n";
        foreach (Word word in words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display.Trim();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.isHidden())
                return false;
        }
        return true;
    }
}