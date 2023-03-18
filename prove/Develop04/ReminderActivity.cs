class ReminderActivity : Activity
    {
        public ReminderActivity()
        {
            Console.WriteLine("This activity will help you remember to do something.");
        }

        public override void Start()
        {
            // Start activity
            base.Start();

            // Perform activity
            Console.WriteLine("Type what would you like to remember to do?");
            string reminder = Console.ReadLine();
            Console.WriteLine("You will be reminded to " + reminder + " in " + duration + " seconds.");
            System.Threading.Thread.Sleep(duration * 1000);
            Console.WriteLine();
            Console.WriteLine("Remember to " + reminder + "!\n");
        }
    }