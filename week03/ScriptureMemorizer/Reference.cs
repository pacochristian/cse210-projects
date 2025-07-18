public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = -1;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = endVerse;    
    }
    public string GetDisplayText()
    {
        return endVerse == -1 
        ? $"{book} {chapter}:{verse}"
        : $"{book} {chapter}: {verse}-{endVerse}";
    }
}