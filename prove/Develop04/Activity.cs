public class Activity
{
    // Protected fields to store the starting message, name, and duration of the activity
    protected string _startingMessage;
    protected string _name;
    protected int _duration;

    // Constructor to initialize the fields
    public Activity(string startingMessage, string name, int duration)
    {
        _startingMessage = startingMessage;
        _name = name;
        _duration = duration;
    }

    // Getter method for the starting message
    public string GetStartingMessage()
    {
        return _startingMessage;
    }

    // Getter method for the name
    public string GetName()
    {
        return _name;
    }

    // Getter method for the duration
    public int Getduration()
    {
        return _duration;
    }

    // Setter method for the duration
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Setter method for the name
    public void SetName(string name)
    {
        _name = name;
    }

    // Setter method for the starting message
    public void SetStartingMessage(string startingMessage)
    {
        _startingMessage = startingMessage;
    }

    // Method to display a spinner animation for a given number of seconds
    public void showSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        for (int i = 1; i < seconds * 4; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            spinnerIndex = (spinnerIndex + 1) % 4;
        }
    }

    // Method to display the introduction message
    public void showIntro()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_startingMessage);
    }

    // Method to display a countdown for a given number of seconds
    public void showCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    // Method to display the completion message of the activity
    public void finishActivity()
    {
        Console.WriteLine($"You have completed {Getduration()} seconds of {_name} Activity.");
        Thread.Sleep(3000);
    }
}