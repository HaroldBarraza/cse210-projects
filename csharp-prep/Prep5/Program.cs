using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string namers = PromptUserName();
        int numbers = PromptUserNumber();
        int squares = SquareNumber(numbers);
        DisplayResult(namers , squares);


    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program !!!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favorite = Console.ReadLine();
        int number = int.Parse(favorite);

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, The square of your number is {square}.");
    }

}