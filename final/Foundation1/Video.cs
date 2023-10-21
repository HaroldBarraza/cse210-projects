class Video
{
    private string _Title { get; set; }
    private string _Author { get; set; }
    private int _Duration { get; set; }
    public List<Comment> _Comments { get; set; } = new List<Comment>();

    public Video(string Title, string Author, int Duration)
    {
        _Title = Title;
        _Author = Author;
        _Duration = Duration;
    }

    public void AddComment(string CommenterName, string Text)
    {
        Comment comment = new Comment(CommenterName, Text);
        _Comments.Add(comment);
    }

    public int GetNumComments()
    {
        return _Comments.Count;
    }

    public string GetTitle()
    {
        return _Title;
    }

    public string GetAuthor()
    {
        return _Author;
    }

    public int GetDuration()
    {
        return _Duration;
    }

    public List<Comment> GetComments()
    {
        return _Comments;
    }
}