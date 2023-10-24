class Running : Activity
{
    private double _Distance {get; set;}

    public Running(DateTime Date, int DurationMinutes, double Distance)
    : base(Date, DurationMinutes)
    {
        _Distance = Distance;
    }
    public override double GetDistance()
    {
        return _Distance;
    }
    public override double GetSpeed()
    {
        return _Distance / (GetDurationMinutes() / 60);
    }
    public override string GetPace()
    {
        return $"{GetDurationMinutes() / _Distance:F1} min er Km";
    }
}