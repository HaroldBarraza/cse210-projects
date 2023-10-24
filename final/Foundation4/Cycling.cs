class Cycling : Activity
{
    private double _Speed {get; set;}

    public Cycling(DateTime Date, int DurationMinutes, double Speed)
    : base(Date, DurationMinutes)
    {
        _Speed = Speed;
    }
    public override double GetSpeed()
    {
        return _Speed;
    }
    public override double GetDistance()
    {
        return _Speed * (GetDurationMinutes() / 60);
    }
    public override string GetPace()
    {
        return $"{60 / _Speed:F1} min per mile";
    }
} 
