
public class Reflecting : Activity
{
    public Reflecting(string startingMessage, string name, int duration) : base(startingMessage, name, duration)
    {

    }
    // Main method to run 
    public void Run()
    {
        Console.Clear();
        showIntro();
        Console.WriteLine("How many seconds would you like to reflect for?");
        string response = Console.ReadLine();
        while (true)
        {
            bool sucess = int.TryParse(response, out int seconds);
            if (sucess)
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
        Console.Clear();

        Console.WriteLine("Get ready...");
        showSpinner(3);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {selectPrompt()} ---");
        Console.WriteLine("When you have something in mind press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to the prompt:");

        Console.WriteLine("You may begin in:");
        showCountdown(5);

        for (int i = 0; i < Getduration(); i = i + 4)
        {
            Console.WriteLine(selectQuestion());
            showSpinner(4);
        }

        finishActivity();
    }

    private List<string> usedPrompts = new List<string>();
    private List<string> availablePrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string selectPrompt()
    {
        // If all prompts have been used, reset available prompts
        if (availablePrompts.Count == 0)
        {
            availablePrompts.AddRange(usedPrompts);
            usedPrompts.Clear();
        }

        // Select a random prompt from the list
        Random random = new Random();
        int index = random.Next(availablePrompts.Count);
        string selectedPrompt = availablePrompts[index];

        // Remove the selected prompt from the available prompts and add it to the used prompts
        availablePrompts.RemoveAt(index);
        usedPrompts.Add(selectedPrompt);

        // Return the selected prompt
        return selectedPrompt;
    }

   private int currentQuestionIndex = 0;
    private string selectQuestion()
    {
        string[] questions = new string[]
        {
            "What did you learn from this experience?",
            "How did you feel during this experience?",
            "What would you do differently if you could go back?",
            "How did this experience change you?",
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        
        string question = questions[currentQuestionIndex % questions.Length];
        currentQuestionIndex++;
        return question;
    }
}