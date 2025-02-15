using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What Scripture would you like to memorize?");
        string reference = Console.ReadLine();
        Reference reference1 = new Reference(reference);
        Scripture scripture = new Scripture(reference1);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayScriputure());
            Console.WriteLine("Press enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();
            Console.Clear();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
            if (scripture.IsAllHidden())
            {
                Console.WriteLine("You have memorized the scripture!");
                break;
            }
        }
    }
}