using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your firts name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name?  ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");
        Console.ReadLine();
        
    }
}