public class MathAssignment : Assignement
{
    private string _textBook;
    private string _problem;

    public MathAssignment(string name, string topic, string textBook, string problem ) : base(name, topic)
    {
        _textBook = textBook;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBook} Problemas {_problem} ";
    }
}