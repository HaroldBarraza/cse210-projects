using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(1,101);

        int usernumber = -1;

        while (number != usernumber)
        {
            Console.WriteLine("What is your guess? ");
            usernumber = int.Parse(Console.ReadLine());
            
            if (number > usernumber)
            {
                Console.WriteLine("Higher");
            }
            else if (number < usernumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}