using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the journal Program!");
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following choices:");

        int menuUserInput = 0;

        Journal journal = new Journal();


        List<string> menu = new List<string>
            {
                "Please enter a number:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "Your number: "
            };

            while (menuUserInput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());

            switch(menuUserInput) {
                case 1:
                    journal.CreateJournalEntries();
                    break;
                case 2:
                    journal.DisplayJournalEntries();
                    break;
                case 3:
                    journal.LoadFromTXT(); 
                    break;
                case 4:
                    journal.SaveToTXT();
                    break;
                case 5:
                    Console.WriteLine("See you tomorrow!");
                    break;
                default:
                    Console.Write("Please choose a valid number:\n");
                    break;
            }
        }
    }
}