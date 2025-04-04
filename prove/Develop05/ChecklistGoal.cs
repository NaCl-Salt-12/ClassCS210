// Represents a goal that requires multiple completions to achieve a bonus
public class ChecklistGoal : Goal
{
    // The total number of completions required to achieve the goal
    private int _targetCount;

    // The current number of completions achieved
    private int _currentCount;

    // The bonus points awarded upon completing the goal
    private int _bonusPoints;

    // Constructor to initialize the checklist goal with its properties
    public ChecklistGoal(string name, string description, int pointValue, int targetCount, int bonusPoints) 
        : base(name, description, pointValue)
    {
        _targetCount = targetCount; // Set the target number of completions
        _currentCount = 0;         // Initialize the current count to zero
        _bonusPoints = bonusPoints; // Set the bonus points for completing the goal
    }

    // Determines if the goal is completed by checking if the current count meets or exceeds the target count
    public override bool IsCompleted() => _currentCount >= _targetCount;

    // Records an event (completion) for the goal and calculates the points earned
    public override int RecordEvent()
    {
        // Check if the goal has not yet reached the target count
        if (_currentCount < _targetCount)
        {
            _currentCount++; // Increment the current count
            int pointsEarned = GetPointValue(); // Add the base point value

            // If the target count is reached, mark the goal as completed and add bonus points
            if (_currentCount == _targetCount)
            {
                _isCompleted = true; // Mark the goal as completed
                pointsEarned += _bonusPoints; // Add the bonus points
            }
            return pointsEarned; // Return the total points earned
        }
        return 0; // Return zero points if the goal is already completed
    }

    // Returns a string representation of the goal's details for display
    public override string GetDetails()
    {
        // Display the completion status, name, description, and progress
        return $"{(_isCompleted ? "[X]" : "[ ]")} {GetName()} ({GetDescription()}) -Completed {_currentCount}/{_targetCount} times)";
    }

    // Returns a string representation of the goal for saving to a file
    public override string GetStringRepresentation()
    {
        // Format: "ChecklistGoal:<name>|<description>|<pointValue>|<bonusPoints>|<targetCount>|<currentCount>|"
        return $"ChecklistGoal:{GetName()}|{GetDescription()}|{GetPointValue()}|{_bonusPoints}|{_targetCount}|{_currentCount}|";
    }

    // Creates a ChecklistGoal object from its string representation
    public static new ChecklistGoal CreateFromString(string representation)
    {
        // Split the string to extract the goal's properties
        string[] parts = representation.Split(':')[1].Split('|');
        ChecklistGoal goal = new ChecklistGoal(
            parts[0], // Name
            parts[1], // Description
            int.Parse(parts[2]), // Point value
            int.Parse(parts[4]), // Target count
            int.Parse(parts[3])  // Bonus points
        );

        // Set the current count from the string representation
        goal._currentCount = int.Parse(parts[5]);

        // Mark the goal as completed if the current count meets or exceeds the target count
        goal._isCompleted = goal._currentCount >= goal._targetCount;

        return goal; // Return the created ChecklistGoal object
    }
}