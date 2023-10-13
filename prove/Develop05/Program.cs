using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        goals.Add(new SimpleGoal("Run a Marathon", 1000));
        goals.Add(new EternalGoal("Read Scriptures", 100));
        goals.Add(new ChecklistGoal("Attend the Temple", 50, 10));

        goals.ForEach(goal => goal.RecordEvent());

        Console.WriteLine("Goal Status:");
        goals.ForEach(goal => Console.WriteLine(goal.GetStatus()));

        SaveGoalsToFile(goals, "goals.txt");

        List<Goal> loadedGoals = LoadGoalsFromFile("goals.txt");

        Console.WriteLine("\nLoaded Goal Status:");
        loadedGoals.ForEach(goal => Console.WriteLine(goal.GetStatus()));
    }

    static void SaveGoalsToFile(List<Goal> goals, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            goals.ForEach(goal => outputFile.WriteLine(goal.GetStringRepresentation()));
        }
    }

    static List<Goal> LoadGoalsFromFile(string filename)
    {
        List<Goal> loadedGoals = new List<Goal>();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            if (parts.Length >= 3)
            {
                string goalType = parts[0];
                string goalName = parts[1];

                switch (goalType)
                {
                    case "SimpleGoal":
                        loadedGoals.Add(new SimpleGoal(goalName, int.Parse(parts[2])));
                        break;
                    case "EternalGoal":
                        loadedGoals.Add(new EternalGoal(goalName, int.Parse(parts[2])));
                        break;
                    case "ChecklistGoal":
                        if (parts.Length >= 4)
                        {
                            loadedGoals.Add(new ChecklistGoal(goalName, int.Parse(parts[2]), int.Parse(parts[3])));
                        }
                        break;
                }
            }
        }

        return loadedGoals;
    }
}