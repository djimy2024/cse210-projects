public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void CreateGoal(string type)
    {
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }

        goals.Add(goal);
        Console.WriteLine($"Goal '{name}' created!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        DisplayGoals();
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = goals[index];
        goal.RecordEvent();
        _score += goal.IsComplete() ? goal._points : 0;
    }

    public void DisplayGoals()
    {
          // Check if there are any goals in the list
        if (goals.Count == 0)
        {
            Console.WriteLine("You have no goals at the moment.");
        }
        else
        {
            Console.WriteLine("\nYour Goals:");
        foreach (Goal goal in goals)
            {
               Console.WriteLine(goal.GetDetailsString());
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYour score: {_score}");
    }

    public void SaveGoals()
    {
        string fileName = "Goals.txt";  // File to save the goals
        using (StreamWriter writer = new StreamWriter(fileName))
        {
        foreach (Goal goal in goals)
            {
                // Each goal is represented by a line of text
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        string fileName = "Goals.txt";  // File to load goals from

    if (File.Exists(fileName))
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Parse each line and recreate the appropriate goal object
                string[] parts = line.Split(','); // Assume goals are delimited by ','
                if (parts.Length == 4) // SimpleGoal
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool _isComplete = bool.Parse(parts[3]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    //goal.IsComplete = _isComplete;
                    goals.Add(goal);
                }
                    else if (parts.Length == 5) // EternalGoal
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    EternalGoal goal = new EternalGoal(name, description, points);
                    goals.Add(goal);
                }
                  else if (parts.Length == 6) // ChecklistGoal
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int target = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
    else
       {
        Console.WriteLine("No goals file found.");
       }
    }
}
