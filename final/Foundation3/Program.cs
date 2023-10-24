using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address ("124 Main St", "CityVille", "CA", "US");

        Event conference = new Conference("Conference 2023", "Tech Conference", DateTime.Parse("2023-11-15"), "09:00 AM", eventAddress,"John Doe", 200);
        Event reception = new Reception("Reception 2023", "Networking Reception", DateTime.Parse("2023-12-15"), "10:30 AM", eventAddress, "net@gmail.com");     
        Event MeetingEvent = new OutdoorMeeting("Outdoor Meeting 2023", "Team Building", DateTime.Parse("2023-10-20"), "05:00 PM", eventAddress,"Sunny day");

        Event[] events = {conference, reception, MeetingEvent};

        foreach (var i in events)
        {
            Console.WriteLine("Standart Details:");
            Console.WriteLine(i.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(i.GetFullDetails());
            Console.WriteLine("\nShort Descriptions:");
            Console.WriteLine(i.GetShortDescrption());
            Console.WriteLine("\n");
        }
    }
}