public class UserInterface 
{ private GoalManager _goalManager;
    private LevelSystem _levelSystem;

    public UserInterface()
    {
        _goalManager = new GoalManager();
        _levelSystem = new LevelSystem();
    }

    public void Run()
    {
        bool quit = false;
        while (!quit)
        {
            DisplayMenu();
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    public void DisplayMenu()
    {
        Console.WriteLine("\n===== Eternal Quest Menu =====");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Display Score and Level");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Quit");
    }     

    public void CreateNewGoal()
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. EternalGoal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        int pointValue = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, pointValue);
                break;
            case "2":
            newGoal = new EternalGoal(name, description, pointValue);
                break;
            case "3":
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                int targetCount = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, pointValue, targetCount, bonusPoints);
                break;
            
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }
        if (newGoal != null)
        {
            _goalManager.AddGoal(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
    }
    public void DisplayGoals()
    {
        _goalManager.DisplayGoals();
    }

    public void RecordEvent()
    {
        _goalManager.DisplayGoals();

        Console.Write("\nWhich goal did you accomplish? (Enter the number): ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        _goalManager.RecordEvent(goalIndex);
        Console.WriteLine("Event recorded successfully!");

        DisplayScore();

    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();
        _goalManager.SaveGoals(filename);
        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();
        _goalManager.LoadGoals(filename);
        Console.WriteLine("Goals loaded successfully!");
    }
    public void DisplayScore()
    {
        // Retrieve the current score from the GoalManager
        int score = _goalManager.GetScore();

        // Determine the current level based on the score
        int level = _levelSystem.GetCurrentLevel(score);

        // Get the title associated with the current level
        string title = _levelSystem.GetLevelTitle(level);

        // Display the user's current score, level, and level title
        Console.WriteLine($"\n You have {score} points.");
        Console.WriteLine($"You are currently at level {level} - {title}");

        // Get the score threshold for the next level
        int nextLevelThreshold = _levelSystem.GetNextLevelThreshold(score);

        // Check if there is a next level
        if (nextLevelThreshold > 0)
        {
            // Calculate the progress towards the next level as a percentage
            float progress = _levelSystem.GetLevelProgress(score);

            // Calculate the points needed to reach the next level
            int pointsNeeded = nextLevelThreshold - score;

            // Display the progress percentage and points needed for the next level
            Console.WriteLine($"Progress to next level: {progress * 100:F1}%");
            Console.WriteLine("Points needed for level {level + 1}: " + pointsNeeded);
        }
        else
        {
            // If no next level exists, display a congratulatory message
            Console.WriteLine("Congratulations! You have reached the maximum level!");
        }
    }
}