using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guessedNumber = 23;

        while (guessedNumber != number)
        {
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());

            if (number > guessedNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guessedNumber)
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