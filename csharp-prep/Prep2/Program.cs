using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your mark");
        string valueFromUser = Console.ReadLine();
        int mark = int.Parse(valueFromUser);

        string grade = "";

        if (mark <= 90)
        {
          grade = "A" ; 
        }
        else if (mark >= 80)
        {
            grade = "B";
        }
        else if (mark >= 70)
        {
            grade = "C";
        }
        else if (mark >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is: {grade}");
        
        if (mark >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}