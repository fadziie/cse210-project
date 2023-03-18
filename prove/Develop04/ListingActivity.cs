class ListingActivity : Activity
    {
        public ListingActivity()
        {
            Console.WriteLine("This activity will help you organize your thoughts by listing things.");
        }

        public override void Start()
        {
            // Start activity
            base.Start();
            // Get prompt
            string[] prompts = new string[] {
            "Who are people that you appreciate?.",
            "What are personal strengths of yours?.",
            "Who are people that you have helped this week?.",
            "When have you felt the Holy Ghost this month?.",
            "Who are some of your personal heroes?."};

            Random random = new Random();
            int index = random.Next(prompts.Length);
            string prompt = prompts[index];

            // Perform activity
            Console.WriteLine(prompt);

            // Get list
            string[] list = new string[duration];


            // Perform activity
            for (int i = 0; i < duration / 2; i++)
            {
                Animation.Pause();
            }
        }
    }