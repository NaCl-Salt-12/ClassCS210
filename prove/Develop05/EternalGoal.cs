// Represents a goal that can be completed multiple times for a fixed point value each time
public class EternalGoal : Goal
{
    // Tracks how many times the goal has been completed
    private int _timesCompleted;

    // Constructor to initialize the EternalGoal with its name, description, and point value
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        _timesCompleted = 0; // Initialize the completion count to zero
    }

    // Records the completion of the goal and returns the point value earned
    public override int RecordEvent()
    {
        _timesCompleted++; // Increment the completion count
        return GetPointValue(); // Return the point value for this goal
    }

    // Returns a string with the goal's details, including how many times it has been completed
    public override string GetDetails()
    {
        return $"{GetName()} ({GetDescription()})  - completed {_timesCompleted} times";
    }

    // Returns a string representation of the goal for saving to a file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()}|{GetDescription()}|{GetPointValue()}|{_timesCompleted}";
    }

    // Creates an EternalGoal object from its string representation
    public static new EternalGoal CreateFromString(string representation)
    {
        // Split the string to extract the goal's properties
        string[] parts = representation.Split(':')[1].Split('|');
        EternalGoal goal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2])); // Create a new EternalGoal
        goal._timesCompleted = int.Parse(parts[3]); // Set the completion count
        return goal; // Return the created EternalGoal object
    }
}