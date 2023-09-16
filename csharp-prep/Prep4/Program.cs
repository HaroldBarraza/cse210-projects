using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        int user = -1;
        while (user != 0)
        {
            Console.WriteLine("enter your number or 0 to quit:  ");

            string typeuser = Console.ReadLine();
            user = int.Parse(typeuser);

            if (user !=0)
            {
                number.Add(user);
            }
        }
        int sum = 0;

        foreach(int num in number)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is {sum}");

        float media = ((float)sum) / number.Count;
        Console.WriteLine($"The average is {media}");

        int maxnumber = number[0];
        foreach(int num in number)
        {
            if (num > maxnumber)
            {
                maxnumber = num;
            }
        }
        Console.WriteLine($"The largest number is {maxnumber}");
    }
}