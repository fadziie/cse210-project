 class Activity
    {
        public int duration;
        public virtual void Start()
        {
            // Get duration from user
            Console.Write("How long would you like to do this activity for? (in seconds) ");
            duration = int.Parse(Console.ReadLine());


            // Start activity
            Animation.Countdown();
        }
    }