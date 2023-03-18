    class ReflectionActivity : Activity
    {
        public ReflectionActivity()
        {
            Console.WriteLine("This activity will help you reflect on your thoughts and emotions.");
        }

        public override void Start()
        {
            // Start activity
            base.Start();

            // Get prompt
            string[] prompts = new string[] {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
            Random random = new Random();
            int promptIndex = random.Next(prompts.Length);
            string prompt = prompts[promptIndex];


            // Perform activity
            for (int i = 0; i < duration / 2; i++)
            {
                Console.WriteLine("Reflect about the following questions.\n");
                // Get question
                string[] questions = new string[] {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
                int questionIndex = random.Next(questions.Length);
                string question = questions[questionIndex];

                // Ask question
                Console.WriteLine(question);
                Animation.Pause();

                Animation.Pause();
            }
        }
    }
