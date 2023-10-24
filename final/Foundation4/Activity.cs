class Activity
{
    private DateTime _Date {get; set;}
    private int _DurationMinutes {get; set;}

    public Activity(DateTime Date, int DurationMinutes)
    {
        _Date = Date;
        _DurationMinutes = DurationMinutes;
    } 

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual string GetPace()
    {
        return "N/A";
    }

    public virtual string GetSummary()
    {
        return $"{_Date:dd MMM yyyy} {GetType().Name} ({_DurationMinutes} min)";
    }
    public int GetDurationMinutes()
    {
        return _DurationMinutes;
    }
}