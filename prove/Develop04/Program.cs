using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
         Mindfulness mindfulness = new Mindfulness();

            mindfulness.Run();

            Console.ReadKey();
        }
    }

    class Mindfulness
    {
        Menu menu = new Menu();

        public void Run()
        {
            // Show menu options
            menu.Show();

            // Get user input
            int choice = int.Parse(Console.ReadLine());

            // Perform selected activity
            Activity activity;
            switch (choice)
            {
                case 1:
                    // Start Breathing Activity
                    activity = new BreathingActivity();
                    activity.Start();
                    break;
                case 2:
                    // Start Reflection Activity
                    activity = new ReflectionActivity();
                    activity.Start();
                    break;
                case 3:
                    // Start Listing Activity
                    activity = new ListingActivity();
                    activity.Start();
                    break;
                case 4:
                    // Start reminder activity
                    activity = new ReminderActivity();
                    activity.Start();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    return;
            }

            // Show end message
            Console.WriteLine("Good job! You have completed the activity.");
            Console.WriteLine("Duration: " + activity.duration + " seconds");
            Console.WriteLine("Press any key to exit.");
        }
    }

    class Animation
    {
        public static void Spinner()
        {
            Console.Write("Starting in ");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i + " ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public static void Pause()
        {
            Console.Write("Pause");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public static void Countdown()
        {
            Console.Write("Starting in ");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i + " ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }

    class Menu
    {
        public void Show()
        {
            Console.WriteLine("Welcome to Mindfulness!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Reminder Activity");
        }
    }



