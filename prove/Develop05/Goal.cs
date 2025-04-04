// Abstract base class that defines the structure for all goal types
public abstract class Goal
{
    // Private fields to store basic goal information
    private string _name;          // The name of the goal
    private string _description;   // A description of what the goal involves
    private int _pointValue;       // How many points this goal is worth when completed
    
    // Protected field allowing derived classes to access completion status
    protected bool _isCompleted;   // Whether the goal has been completed

    // Constructor that initializes a new goal with basic information
    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isCompleted = false;      // All goals start as not completed
    }
    
    // Getter method to access the goal's name
    public string GetName()
    {
        return _name;
    }
    
    // Getter method to access the goal's description
    public string GetDescription()
    {
        return _description;
    }
    
    // Getter method to access the goal's point value
    public int GetPointValue()
    {
        return _pointValue;
    }
    
    // Virtual method that can be overridden by derived classes 
    // Returns whether the goal is completed
    public virtual bool IsCompleted()
    {
        return _isCompleted;
    }
    
    // Abstract method that must be implemented by derived classes
    // Records when an event for this goal is completed and returns points earned
    public abstract int RecordEvent();
    
    // Abstract method that must be implemented by derived classes
    // Returns a formatted string with details about the goal for display
    public abstract string GetDetails();
    
    // Abstract method that must be implemented by derived classes
    // Returns a string representation of the goal for saving to a file
    public abstract string GetStringRepresentation();
    
    // Static method for creating a Goal object from a string representation
    // Returns null by default, intended to be overridden by static methods in derived classes
    public static Goal CreateFromString(string repersentation) => null;
}