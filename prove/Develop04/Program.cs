using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu");

            Console.WriteLine("1. Breathing Activity ");
            Console.WriteLine("2. Reflection Activity ");
            Console.WriteLine("3. Listing Activity ");
            Console.WriteLine("4. Quit ");

            Console.WriteLine("Choose an option");
            string choose = Console.ReadLine();

            switch(choose)
            {
                case "1":
                Execute(new BreathingActivity("BreathingActivity", 5));
                break;

                case "2":
                Execute(new ReflectionActivity("Reflection Activity", 1));
                break;

                case "3":
                Execute(new ListingActivity("ListingActivity", 8));
                break;

                case "4":
                Environment.Exit(0);
                break;

                case "5":
                Console.WriteLine("the option is incorrect");
                break;

                

            }
        }
    }
    static void Execute(Activity activity)
    {
        activity.Start();
        activity.End();
    }
}
