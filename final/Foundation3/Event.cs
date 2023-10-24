class Event
{
    private string _Tittle {get; set;}
    private string _Description {get; set;}
    private DateTime _Date {get; set;}
    private string _Time {get; set;}
    private Address _Location {get; set;}

    public Event(string Tittle, string Description, DateTime Date, string Time, Address Location)
    {
        _Tittle = Tittle;
        _Description = Description;
        _Date = Date;
        _Time = Time;
        _Location = Location;
    }

    public string GetStandardDetails()
    {
        return $"Tittle {_Tittle}, Description {_Description}, Date {_Date}, Time {_Time}, Location: {_Location.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescrption()
    {
        return $"Event Type: {GetType().Name}, Tittle: {_Tittle}, Date: {_Date}";
    }
}