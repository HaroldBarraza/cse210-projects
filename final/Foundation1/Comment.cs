class Comment
{
    private string _CommenterName { get; set; }
    private string _Text { get; set; }

    public Comment(string CommenterName, string Text)
    {
        _CommenterName = CommenterName;
        _Text = Text;
    }

    public string GetCommenterName()
    {
        return _CommenterName;
    }

    public string GetText()
    {
        return _Text;
    }
}
