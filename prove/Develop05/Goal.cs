public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; protected set; }

    public Goal(string name)
    {
        Name = name;
    }

    public abstract void RecordEvent();

    public virtual string GetStatus()
    {
        return $"[{(IsComplete() ? 'X' : ' ')}] {Name}";
    }

    protected abstract bool IsComplete();

    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{Name}";
    }
}