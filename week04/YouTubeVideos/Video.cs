public class Video
{
    //Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    //List to hold comments 
    private List<Comment> CommentList = new List<Comment>();
    //Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }
    //Method to add a comment 
    public void AddComment(Comment comment)
    {
        CommentList.Add(comment);
    }
    //Method to get number of comments
    public int GetCommentCount()
    {
        return CommentList.Count;
    }

    //list out all of the comments
    public List<Comment> GetComments()
    {
        return CommentList;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"{Title} by {Author} | {Length} second long | {GetCommentCount()} comment(s):");
        Console.WriteLine();
        foreach (Comment comment in CommentList)
        {
            Console.WriteLine($"-{comment.Commenter}: {comment.CommenterText}");
        }

    }
}