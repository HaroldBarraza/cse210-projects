using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Diary diary = new Diary();

        bool isRunning = true;
        while (isRunning)
        {
            // Display menu options
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Show the diary");
            Console.WriteLine("3. Save the diary to a file");
            Console.WriteLine("4. Load the diary from a file");
            Console.WriteLine("5. Exit");

            // Get user's choice
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    diary.WriteNewEntry();
                    break;
                case 2:
                    diary.DisplayDiary();
                    break;
                case 3:
                    diary.SaveDiary();
                    break;
                case 4:
                    diary.LoadDiary();
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

class Entry
{
    public string Question { get; set; }
    public string Answer { get; set; }
    public DateTime Date { get; set; }

    public Entry(string question, string answer, DateTime date)
    {
        Question = question;
        Answer = answer;
        Date = date;
    }
}

class Diary
{
    private List<Entry> entries;

    public Diary()
    {
        entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
        // List of questions
        List<string> questions = new List<string>
        {
            "How are you feeling today?",
            "What challenges did you face today and how did you overcome them?",
            "Who did you interact with today and what did you learn from those interactions?",
            "What was your most significant accomplishment of the day?",
            "What are your goals for tomorrow?",
            "What things made you smile or laugh today?",
            "What was your moment of greatest gratitude today?",
            "What were three positive things that happened in your day today?",
            "What important lessons did you learn today?"
        };

        // Get a random question
        Random random = new Random();
        int index = random.Next(questions.Count);
        string question = questions[index];

        // Get user's answer
        Console.WriteLine(question);
        string answer = Console.ReadLine();

        // Create a new entry and add it to the diary
        Entry entry = new Entry(question, answer, DateTime.Now);
        entries.Add(entry);

        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayDiary()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The diary is empty.");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"{entry.Date} - {entry.Question}: {entry.Answer}");
            }
        }
    }

    public void SaveDiary()
    {
        Console.Write("Enter the file name to save the diary: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Question},{entry.Answer}");
                }
            }

            Console.WriteLine("Diary saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the diary: {ex.Message}");
        }
    }

    public void LoadDiary()
    {
        Console.Write("Enter the file name to load the diary: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                entries.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string dateStr = parts[0];
                        string question = parts[1];
                        string answer = parts[2];

                        DateTime date = DateTime.Parse(dateStr);
                        Entry entry = new Entry(question, answer, date);
                        entries.Add(entry);
                    }
                }
            }

            Console.WriteLine("Diary loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the diary: {ex.Message}");
        }
    }
}
