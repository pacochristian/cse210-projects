public class Comment
{
    public string Commenter { get; set; }
    public string CommenterText { get; set; }

    public Comment(string commenter, string commentertext)
    {
        Commenter = commenter;
        CommenterText = commentertext;
    }
}