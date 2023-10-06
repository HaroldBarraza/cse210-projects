using System;

class Program
{
    static void Main(string[] args)
    {
        Assignement A1 = new Assignement("Samuel Bennet", "Multiplication");
        Console.WriteLine(A1.GetSummary());

        MathAssignment A2 = new MathAssignment("Roberto Rodriguez","Fractions", "7.3", "8-19");
        Console.WriteLine(A2.GetSummary());
        Console.WriteLine(A2.GetHomeworkList());

        WritingAssignment A3 = new WritingAssignment("Mary Waters","European History", "The Causes of World War II");
        Console.WriteLine(A3.GetSummary());
        Console.WriteLine(A3.GetWritingInformation());
    }
}

