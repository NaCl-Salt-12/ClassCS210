public class GoalManager
{
    // List to store all the goals created by the user
    private List<Goal> _goals;

    // Variable to keep track of the user's total score
    private int _score;

    // Constructor to initialize the list of goals and the score
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Method to add a new goal to the list
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to record an event for a specific goal
    public void RecordEvent(int goalIndex)
    {
        // Ensure the goal index is valid
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            // Record the event and update the score
            int pointsEarned = _goals[goalIndex].RecordEvent();
            _score += pointsEarned;

            // Display a message indicating the points earned
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        }
    }

    // Method to retrieve the current score
    public int GetScore()
    {
        return _score;
    }

    // Method to display all the goals in the list
    public void DisplayGoals()
    {
        // Check if there are no goals to display
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        // Display each goal with its details
        Console.WriteLine("Your Goals: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    // Method to save the goals and score to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Write the score as the first line
            outputFile.WriteLine(_score);

            // Write each goal's string representation to the file
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    // Method to load goals and score from a file
    public void LoadGoals(string filename)
    {
        // Check if the file exists
        if (File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        // Clear the current list of goals
        _goals.Clear();

        // Read all lines from the file
        string[] lines = File.ReadAllLines(filename);

        // Parse the score from the first line
        _score = int.Parse(lines[0]);

        // Parse each goal from the subsequent lines
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string goalType = parts[0];

            Goal goal = null;

            // Determine the type of goal and create it accordingly
            switch (goalType)
            {
                case "SimpleGoal":
                    goal = SimpleGoal.CreateFromString(line);
                    break;
                case "EternalGoal":
                    goal = EternalGoal.CreateFromString(line);
                    break;
                case "ChecklistGoal":
                    goal = ChecklistGoal.CreateFromString(line);
                    break;
            }

            // Add the goal to the list if it was successfully created
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
    }

    // Placeholder method to create a goal based on its type
    public Goal CreateGoal(string type)
    {
        return null;
    }
}