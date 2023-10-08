
public class ListingActivity : Activity
{
    private string[] _indications =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(string name ,int time) : base(name)
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _time = time; 
    }
    public override void Start()
    {
        base.Star();
        Console.WriteLine(_description);

        Console.WriteLine("================================================================================================================================");

        string random = _indications[new Random().Next(_indications.Length)];
        Console.WriteLine(random);

        Simulation(25);
        Console.WriteLine("get ready to list");
        
    }
}