public class Assignement
{
    private string _name;
    private string _topic;

    public Assignement(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _name + "-" + _topic;
    }
}