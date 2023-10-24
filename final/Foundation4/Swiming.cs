class Swiming : Activity
{
    private int _Laps {get; set;}

    public Swiming(DateTime Date, int DurationMinutes, int Laps)
     : base(Date, DurationMinutes)
     {
        _Laps = Laps;
     }
    public override double GetDistance()
    {
        return _Laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        if (GetDurationMinutes() == 0)
        {
            return 0;
        }

        double distanceKilometers = _Laps * 50 / 1000;
        double speedKph = distanceKilometers / (GetDurationMinutes() / 60);

        return speedKph;
    }
    public override string GetPace()
    {
        return $"{GetDurationMinutes() / (_Laps * 50 / 1000): F1} min per km";
    }
}