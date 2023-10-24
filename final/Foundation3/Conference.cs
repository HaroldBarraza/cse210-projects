class Conference : Event
{
    private string _SpeakerName {get; set;}
    private int _Capacity {get; set;}

    public Conference(string Tittle, string Description, DateTime Date, string Time, Address Location, string SpeakerName, int Capacity) : base(Tittle, Description, Date, Time, Location)
    {
        _SpeakerName = SpeakerName; 
        _Capacity = Capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $", Speaker {_SpeakerName}, Capacity {_Capacity}";
    } 
}