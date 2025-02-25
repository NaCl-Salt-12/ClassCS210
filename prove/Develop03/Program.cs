using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the scripture reference from the user.
        Console.WriteLine("What Scripture would you like to memorize?");
        string reference = Console.ReadLine();
        Reference reference1 = new Reference(reference);
        Scripture scripture = new Scripture(reference1);

        // Memorize the scripture.
        while (true)
        {
            // Display the scripture with some words hidden.
            Console.Clear();
            Console.WriteLine(scripture.DisplayScriputure());
            Console.WriteLine("Press enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();
            Console.Clear();
            // Check if the user wants to quit.
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
            // Check if the scripture has been memorized.
            if (scripture.IsAllHidden())
            {
                Console.WriteLine("You have memorized the scripture!");
                break;
            }
        }
    }
}