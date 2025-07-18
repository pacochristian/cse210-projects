public class Word
{
    private string text;
    private bool Hidden;

    public Word(string text)
    {
        this.text = text;
        this.Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public bool isHidden()
    {
        return Hidden;
    }

    public string GetDisplayText()
    {
        return Hidden ? new string('_', text.Length) : text;
    }

}