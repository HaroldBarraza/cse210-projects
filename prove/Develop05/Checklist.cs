public class ChecklistGoal : Goal
{
    private int completedTimes;
    private int requiredTimes;

    public ChecklistGoal(string name, int points, int requiredTimes) : base(name)
    {
        Points = points;
        this.requiredTimes = requiredTimes;
    }

    public override void RecordEvent()
    {
        completedTimes++;
        Console.WriteLine($"Event recorded for {Name}. Gained {Points} points.");

        if (completedTimes == requiredTimes)
        {
            Console.WriteLine($"Congratulations! Bonus {Points * 2} points for completing {requiredTimes} times.");
            Points += Points * 2;
        }
    }

    protected override bool IsComplete()
    {
        return completedTimes == requiredTimes;
    }

    public override string GetStatus()
    {
        return $"{base.GetStatus()} Completed {completedTimes}/{requiredTimes} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}:{requiredTimes}:{completedTimes}";
    }
}