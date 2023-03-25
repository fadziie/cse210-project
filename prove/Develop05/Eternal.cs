public class Eternal : Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }

    public Eternal (string name, string description, int points,string goalType,string complete)
    : base (name, description, points,goalType, complete)
    {

    }

    public Eternal (List<string> goals) : base (goals)
    {
    }


    public override int RecordEvent(int choice)
    {
        if (choice > 0 && choice <= _goals.Count())
        {
            foreach (string goal in _goals)
            {
                if (goal == _goals[choice - 1])
                {
                    string[] parts = goal.Split(",");
                    string points = parts[2];

                    _points = int.Parse(points);
                    Console.WriteLine("\nEvent recorded successfully.");
                    Console.WriteLine($"You have earned {points} points!");
                    Console.ReadKey();
                }
            }
        }
        else
        {
            Console.WriteLine("\nError: invalid choice.");
            Console.ReadKey();
        }
        return _points;
    }
}