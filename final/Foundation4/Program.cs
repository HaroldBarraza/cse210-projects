using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List <Activity>
        {
            new Running(DateTime.Parse("2022-11-03"), 30, 3.0),
            new Cycling(DateTime.Parse("2022-11-03"), 30, 6.0),
            new Swiming(DateTime.Parse("2022-11-03"), 30, 60)
        };
        foreach (var i in activities)
        {
            Console.WriteLine(i.GetSummary());
            Console.WriteLine($"Distance: {i.GetDistance():F1}km");
            Console.WriteLine($"Speed: {i.GetSpeed():F1} kph");
            Console.WriteLine($"Pace: {i.GetPace()}");
            Console.WriteLine();
        }
    }
}