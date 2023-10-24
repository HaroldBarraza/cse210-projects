class OutdoorMeeting : Event
{
    private string _WeatheForecast {get; set;}

    public OutdoorMeeting(string Tittle, string Description, DateTime Date, string Time, Address Location, string WeatheForecast)
    : base(Tittle, Description, Date, Time, Location)
    {
        _WeatheForecast = WeatheForecast;
    }
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $", Weather Forescast: {_WeatheForecast}";
    }

}