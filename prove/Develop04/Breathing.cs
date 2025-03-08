public class Breathing : Activity
{
    // Constructor for the Breathing class, initializes the base Activity class with the provided parameters
    public Breathing(string startingMessage, string name, int duration) : base(startingMessage, name, duration)
    {

    }
    // Method to run the breathing exercise
    public void Run()
    {
        Console.Clear();
        // Display the introduction message
        showIntro();
        
        // Ask the user for the duration of the exercise
        Console.WriteLine("How many seconds would you like to do the breathing exercise for?");
        string response = Console.ReadLine();
        
        // Validate user input to ensure it's a valid number
        while (true)
        {
            bool sucess = int.TryParse(response, out int seconds);
            if (sucess)
            {
                // Set the duration and exit the validation loop
                SetDuration(seconds);
                break;
            }
            else
            {
                // Prompt for valid input if the entry wasn't a number
                Console.WriteLine("Invalid input. Please enter a number.");
                response = Console.ReadLine();
            }
        }

       Console.Clear(); 
        // Prepare the user 
        Console.Write("\nGet ready...");
        showSpinner(3);

        // Main loop - runs for the duration specified
        for (int i = 0; i < Getduration(); i = i + 8)
        {
            // Breathing in phase
            Console.Write("\nBreathe in...");
            showCountdown(4);
            
            // Breathing out phase
            Console.Write("\nBreathe out...");
            showCountdown(4);
        }
        
        // Final message showing the completed duration
        finishActivity();
    }
}