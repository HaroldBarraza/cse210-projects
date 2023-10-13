public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for {Name}. Gained {Points} points.");
    }

    protected override bool IsComplete()
    {
        return true;
    }
}