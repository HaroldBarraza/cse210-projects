class Reception : Event
{
    private string _RsvpEmail {get; set;}

    public Reception(string Tittle, string Description, DateTime Date, string Time, Address Location, string RsvpEmail)
    : base(Tittle, Description, Date, Time, Location)
    {
        _RsvpEmail = RsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $", RSVP Email: {_RsvpEmail}"; 
    }
}