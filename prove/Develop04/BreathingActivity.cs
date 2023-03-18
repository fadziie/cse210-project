 class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            Console.WriteLine("This activity will help you focus on your breathing and relax.");
        }

        public override void Start()
        {
            // Start activity
            base.Start();

            // Perform activity
            for (int i = 0; i < duration / 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Breathe in...");
                }
                else
                {
                    Console.WriteLine("Breathe out...");
                }
                Animation.Pause();
            }
        }
    }