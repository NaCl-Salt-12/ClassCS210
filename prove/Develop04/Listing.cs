public class Listing : Activity
{
    // Constructor for the Listing class, initializes the base class with the provided parameters
    public Listing(string startingMessage, string name, int duration) : base(startingMessage, name, duration)
    {

    }

    // Method to run the listing activity
    public void Run()
    {
        // Clear the console and show the introduction message
        Console.Clear();
        showIntro();

        // Ask the user for the session duration in seconds
        Console.WriteLine("How long in seconds would you like for this session to last?");
        string response = Console.ReadLine();

        // Loop until a valid number is entered
        while (true)
        {
            bool success = int.TryParse(response, out int seconds);
            if (success)
            {
                SetDuration(seconds);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                response = Console.ReadLine();
            }
        }

        // Clear the console and show the ready message
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        showSpinner(3);

        // Display the prompt for the listing activity
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(selectPrompt());

        // Show countdown before starting the activity
        Console.WriteLine("You may begin in:");
        showCountdown(5);

        // Initialize a list to store user responses and set the end time for the activity
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Getduration());

        // Collect user responses until the time is up
        while (DateTime.Now < endTime)
        {
            string userResponse = Console.ReadLine();
            if (!string.IsNullOrEmpty(userResponse))
            {
                responses.Add(userResponse);
            }
        }

        // Display the number of responses collected and finish the activity
        Console.WriteLine($"You have listed {responses.Count} items.");
        finishActivity();
    }

    // List of prompts for the listing activity
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // List to keep track of used prompts
    private List<string> usedPrompts = new List<string>();

    // Method to select a random prompt from the list of prompts
    private string selectPrompt()
    {
        // If all prompts have been used, reset the prompts list
        if (prompts.Count == 0)
        {
            prompts.AddRange(usedPrompts);
            usedPrompts.Clear();
        }

        // Select a random prompt from the list
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string selectedPrompt = prompts[index];

        // Remove the selected prompt from the prompts list and add it to the used prompts list
        prompts.RemoveAt(index);
        usedPrompts.Add(selectedPrompt);

        // Return the selected prompt
        return selectedPrompt;
    }
}