// Represents a simple goal that can be completed once for a fixed point value
public class SimpleGoal : Goal
{
    // Constructor to initialize a SimpleGoal with a name, description, and point value
    public SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
    }

    // Records the completion of the goal and returns the point value if not already completed
    public override int RecordEvent()
    {
        if (!_isCompleted) // Check if the goal is not already completed
        {
            _isCompleted = true; // Mark the goal as completed
            return GetPointValue(); // Return the point value of the goal
        }
        return 0; // Return 0 if the goal was already completed
    }

    // Returns a string representation of the goal's details for display
    public override string GetDetails()
    {
        // Display "[X]" if completed, "[ ]" if not, followed by the name and description
        return $"{(_isCompleted ? "[X]" : "[ ]")} {GetName()} ({GetDescription()})";
    }

    // Returns a string representation of the goal for saving to a file
    public override string GetStringRepresentation()
    {
        // Format: "SimpleGoal:<name>|<description>|<pointValue>|<isCompleted>"
        return $"SimpleGoal:{GetName()}|{GetDescription()}|{GetPointValue()}|{_isCompleted}";
    }

    // Static method to create a SimpleGoal object from its string representation
    public static new SimpleGoal CreateFromString(string representation)
    {
        // Split the string to extract the goal's properties
        string[] parts = representation.Split(':')[1].Split('|');
        SimpleGoal goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2])); // Create a new SimpleGoal
        if (bool.Parse(parts[3])) // Check if the goal was marked as completed
        {
            goal._isCompleted = true; // Set the completion status
        }
        return goal; // Return the created SimpleGoal object
    }
}