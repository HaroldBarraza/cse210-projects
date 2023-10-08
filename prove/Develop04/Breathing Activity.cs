public class BreathingActivity : Activity
{
    public BreathingActivity(string name, int time) : base(name)
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        _time = time;
    }
    public override void Start()
    {
        base.Star();
        Console.WriteLine(_description);

        Console.WriteLine("================================================================================================================================");

        for (int i = 0; i < _time; i++ )
        {
            Console.WriteLine($"inhale...({i + 1}s)");
            Simulation(5);
            Console.WriteLine($"exhale");
            Simulation(5);
        }
    }
}