public class Activity
{
    protected string _nameActiviti;
    protected string _description;
    protected int _time;

    public Activity(string name)
    {
        _nameActiviti = name;
    }

    public virtual void Start()
    {
        Console.WriteLine($"starting activity {_nameActiviti}");
        Console.WriteLine("get ready....");
        ShowAnimation();
    }

    public virtual void End()
    {
        Console.WriteLine($"Congratulations on completing the activity {_nameActiviti}");
        Console.WriteLine($"the time it lasts is {_time}");
        Simulation(10);
    }

    public virtual void Simulation(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write($"Time remaining: {i} seconds\r");
            Thread.Sleep(500);
        }

        Console.WriteLine("Time out!");
    }


    public virtual void ShowAnimation()
        {
        List<string> animations = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        foreach (string s in animations)
        {
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b"); 
        }
    }
}